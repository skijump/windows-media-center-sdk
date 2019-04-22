using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Xml;

using Microsoft.MediaCenter.UI;

namespace Z
{
    /// <summary>
    /// This class contains helper methods and classes designed for experiences
    /// that are targeting a DataSet.
    /// </summary>
    public abstract class DataSetHelpers
    {
        /// <summary>
        /// Get the row in the given table that has a matching value.
        /// Throws an exception if no match or more than one match is found.
        /// </summary>
        public static DataRow GetSingleDataRow(DataTable table, string column, object value)
        {
            string query = String.Format("{0} = '{1}'", column, value);
            DataRow[] matches = table.Select(query);

            if (matches.Length != 1)
                throw new Exception("Unable to find a matching for " + query);

            return matches[0];
        }

        /// <summary>
        /// Given rowSource[columnSource] = value;
        /// Find in tableDestination a row where row[columnDestination] = value;
        /// </summary>
        public static DataRow GetIDMappedDataRow(DataRow rowSource, string columnSource, DataTable tableDestination, string columnDestination)
        {
            object id = rowSource[columnSource];
            return GetSingleDataRow(tableDestination, columnDestination, id);
        }

        /// <summary>
        /// Dump out the contents of a DataSet to the output window.
        /// </summary>
        /// <param name="onlyDumpOneRowPerTable">
        /// If set, only one row per table will be dumped.  This is useful for
        /// debugging the structure of your data set (as opposed to the full
        /// contents)
        /// </param>
        public static void DumpDataSetContents(DataSet dataSet, bool onlyDumpOneRowPerTable)
        {
            Debug.WriteLine("DATASET: " + dataSet.ToString());
            Debug.Indent();

            foreach (DataTable table in dataSet.Tables)
                DumpDataTableContents(table, onlyDumpOneRowPerTable);
            
            Debug.Unindent();
        }

        /// <summary>
        /// Dump out the contents of a DataTable to the output window.
        /// </summary>
        /// <param name="onlyDumpOneRowPerTable">
        /// If set, only one row per table will be dumped.  This is useful for
        /// debugging the structure of your data table (as opposed to the full
        /// contents)
        /// </param>
        public static void DumpDataTableContents(DataTable table, bool onlyDumpOneRowPerTable)
        {
            Debug.WriteLine("Table: " + table.ToString());
            Debug.Indent();

            foreach (DataRow row in table.Rows)
            {
                Debug.WriteLine("Row:");
                Debug.Indent();

                foreach (DataColumn column in table.Columns)
                {
                    Debug.WriteLine(String.Format(System.Globalization.CultureInfo.InvariantCulture,
                        "[{0}] = {1}", column.ColumnName, row[column]));
                }

                Debug.Unindent();

                if (onlyDumpOneRowPerTable)
                    break;
            }

            Debug.Unindent();
        }

        /// <summary>
        /// Create a comma separated string (e.g. "A, B, C")
        /// </summary>
        /// <param name="text">Existing text (may be null/empty)</param>
        /// <param name="value">Value to add to the existing text</param>
        public static void AppendCommaSeparatedValue(ref string text, string value)
        {
            if (String.IsNullOrEmpty(text))
                text = value;
            else
                text = text + ", " + value;
        }

        /// <summary>
        /// A derived thumbnail command class that stores a unique Id for easy
        /// cross-reference into a table.
        /// </summary>
        public class GalleryItem : ThumbnailCommand
        {
            public int ItemId
            {
                get { return itemId; }
                set { itemId = value; }
            }

            private int itemId;
        }

        /// <summary>
        /// A filter (for use with FilteredContentPage.Filters) that also stores
        /// an id to filter on.
        /// </summary>
        /// <seealso cref="FilteredContentPage.Filters"/>
        public class Filter : ModelItem
        {
            public Filter(GalleryPage page, string description, int id)
                : base(page, description)
            {
                filterId = id;
            }

            public int FilterId
            {
                get { return filterId; }
                set { filterId = value; }
            }

            private int filterId;
        }

        /// <summary>
        /// A derived command class that stores a unique Id for easy
        /// cross-reference into a table as well as other extra command
        /// metadata.
        /// </summary>
        public class DetailsCommand : Command
        {
            public DetailsCommand(DetailsPage page, string description)
                : base(page, description, null)
            {
            }

            public int ItemId
            {
                get { return itemId; }
                set { itemId = value; }
            }

            public int Type
            {
                get { return actionType; }
                set { actionType = value; }
            }

            public string Value
            {
                get { return actionValue; }
                set { actionValue = value; }
            }

            private int itemId;
            private int actionType;
            private string actionValue;
        }
    }
}

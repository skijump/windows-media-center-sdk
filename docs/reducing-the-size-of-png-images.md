# Reducing the size of PNG images for use with Media Center Markup Language

If there is one technical oriented blog you should read it has to be Scott Hanselman. This morning I read Be Aware of DPI with Image PNGs in WPF - Images Scale Weird or are Blurry and instantly went 'gee willikers'. Most of the images you use with Media Center Markup Language (MCML) will be in the PNG format if they are part of your <UI> if for no other reason you can embed alpha transparency information within the PNG (which you can't with JPEG or GIF). On a whim I ran the PNG assets we ship with the SDK sampler through PNGOUT and found an average file size savings of just above 50%. This can be a pretty significant size savings for resources in assemblies but can be even more important / significant for web experiences due to bandwidth costs (both in terms of hosting / bandwidth dollars AND perceived responsiveness by the user.

I highly encourage you to click through (and subscribe) to Scotts blog, but if you want the quick tools here is what I used:

PNGOUT (Command Line) http://www.advsys.net/ken/utils.htm

PNGGauntlet (GUI) http://brh.numbera.com/software/pnggauntlet/

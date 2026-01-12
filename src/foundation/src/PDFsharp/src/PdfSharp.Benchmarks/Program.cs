using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using PdfSharp.Drawing;
using PdfSharp.Fonts;

BenchmarkRunner.Run<FontCacheBenchmarks>();

[SimpleJob(RuntimeMoniker.Net80)]
public class FontCacheBenchmarks
{
    private static readonly XGlyphTypeface GlyphTypeface = new(
        XFontSource.CreateFromFile(@"C:\Windows\Fonts\arial.ttf"));
    private static readonly Consumer Consumer = new();

    [Params(1, 10, 100)]
    public int Iterations { get; set; }

    [GlobalSetup]
    public void GlobalSetup()
    {
        FontDescriptorCache.Reset();
        FontDescriptorCacheV2.Reset();
    }

    [GlobalCleanup]
    public void GlobalCleanup()
    {
        FontDescriptorCache.Reset();
        FontDescriptorCacheV2.Reset();
    }

    [Benchmark(Baseline = true)]
    public void LockFactory()
    {
        for (var i = 0; i < Iterations; i++)
        {
            Consumer.Consume(
                FontDescriptorCache.GetOrCreateDescriptorFor(GlyphTypeface));
        }
    }

    [Benchmark]
    public void ConcurrentDictionary()
    {
        for (var i = 0; i < Iterations; i++)
        {
            Consumer.Consume(
                FontDescriptorCacheV2.GetOrCreateDescriptorFor(GlyphTypeface));
        }
    }
}
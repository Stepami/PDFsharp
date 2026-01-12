using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using PdfSharp.Benchmarks;
using PdfSharp.Fonts;
using PdfSharp.Quality;

/*
GlobalFontSettings.FontResolver = new SamplesFontResolver();
var document = CreateSampleDocument();
var filename = PdfFileUtility.GetTempPdfFullFileName("samples/HelloWorldSample");
await document.SaveAsync(filename);
// ...and start a viewer.
PdfFileUtility.ShowDocument(filename);
*/

BenchmarkRunner.Run<PdfDocumentBenchmarks>();

[SimpleJob(RuntimeMoniker.Net80)]
public class PdfDocumentBenchmarks
{
    private static readonly Consumer Consumer = new();

    [Params(1, 10, 100)]
    public int Iterations { get; set; }

    [Benchmark]
    public async Task CreateAndSave()
    {
        for (var i = 0; i < Iterations; i++)
        {
            var document = BenchmarkHelper.CreateSampleDocument();
            Consumer.Consume(document);
            await document.SaveAsync(Stream.Null);
        }
    }

    [GlobalSetup]
    public void GlobalSetup() =>
        GlobalFontSettings.FontResolver = new SamplesFontResolver();
}
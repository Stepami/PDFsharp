using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace PdfSharp.Benchmarks;

public static class BenchmarkHelper
{
    public static PdfDocument CreateSampleDocument()
    {
        // Create a new PDF document.
        var result = new PdfDocument();
        result.Info.Title = "Created with PDFsharp";
        result.Info.Subject = "Just a simple Hello-World program.";

        // Create an empty page in this document.
        var page = result.AddPage();
        page.Size = PageSize.A4;

        // Get an XGraphics object for drawing on this page.
        var gfx = XGraphics.FromPdfPage(page);

        // Create a font.
        var font = new XFont("Times New Roman", 12, XFontStyleEx.BoldItalic);

        // Draw the text.
        gfx.DrawString(
            "Hello, PDFsharp!", font, XBrushes.Black,
            new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
        for (var i = 0; i < 20; i += 2)
        {
            var numbers = Enumerable.Repeat(
                    () => Random.Shared.Next(100, 999), 10)
                .Select(x => x());
            var line = string.Join(
                ", ",
               );
            gfx.DrawString(
                line, font, XBrushes.Black,
                new XRect(0, (i + 1) * 20, page.Width.Point, page.Height.Point),
                XStringFormats.TopLeft);
            gfx.DrawString(
                Guid.NewGuid().ToString(), font, XBrushes.Black,
                new XRect(0, (i + 2) * 20, page.Width.Point, page.Height.Point),
                XStringFormats.TopLeft);
        }

        return result;
    }
}
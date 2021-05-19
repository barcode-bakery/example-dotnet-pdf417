using System.Threading.Tasks;

namespace BarcodePDF417.Core.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // See each barcode file to see how you can save to a file or a MemoryStream.
            await ExamplePDF417.CreateAsync("barcode_pdf417.png");
        }
    }
}

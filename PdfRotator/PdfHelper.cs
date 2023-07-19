using iText.Kernel.Pdf;
namespace PdfRotator {
    /// <summary>
    /// Pdf Helper
    /// </summary>
    public static class PdfHelper {
        /// <summary>
        /// Rotate Pdf
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="rotationNumber"></param>
        /// <param name="rotationPercentage"></param>
        public static void RotatePdf(string input, string output, int rotationNumber = 90, int rotationPercentage = 360) {
            var doc = new PdfDocument(new PdfReader(input), new PdfWriter(output));
            for (var p = 1; p <= doc.GetNumberOfPages(); p++) {
                var page = doc.GetPage(p);
                var rotate = page.GetRotation();
                if (rotate == 0) {
                    page.SetRotation(rotationNumber);
                } else {
                    page.SetRotation((rotate + rotationNumber) % rotationPercentage);
                }
            }
            doc.Close();
        }
    }

}
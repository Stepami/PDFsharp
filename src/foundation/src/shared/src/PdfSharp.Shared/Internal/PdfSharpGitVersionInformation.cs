// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

using System.Globalization;

namespace PdfSharp.Internal
{
    /// <summary>
    /// Product version information from git version tool.
    /// </summary>
    public static class PdfSharpGitVersionInformation
    {
        /// <summary>
        /// The major version number of the product.
        /// </summary>
        public static string Major = "1";//global::GitVersionInformation.Major;

        /// <summary>
        /// The minor version number of the product.
        /// </summary>
        public static string Minor = "1";//global::GitVersionInformation.Minor;

        /// <summary>
        /// The patch number of the product.
        /// </summary>
        public static string Patch = "1";//global::GitVersionInformation.Patch;

        /// <summary>
        /// The Version pre-release string for NuGet.
        /// </summary>
        public static string PreReleaseLabel = string.Empty;//global::GitVersionInformation.PreReleaseLabel;

        /// <summary>
        /// The full version number.
        /// </summary>
        public static string MajorMinorPatch = "1.1.1";//global::GitVersionInformation.MajorMinorPatch;

        /// <summary>
        /// The full semantic version number created by GitVersion.
        /// </summary>
        public static string SemVer = "1.1.1";//global::GitVersionInformation.SemVer;

        /// <summary>
        /// The full informational version number created by GitVersion.
        /// </summary>
        public static string InformationalVersion = "1.1.1";//global::GitVersionInformation.InformationalVersion;

        /// <summary>
        /// The branch name of the product.
        /// </summary>
        public static string BranchName = "refactoring/locks";//global::GitVersionInformation.BranchName;

        /// <summary>
        /// The commit date of the product.
        /// </summary>
        public static string CommitDate = DateTime.Today.ToString(CultureInfo.InvariantCulture);//global::GitVersionInformation.CommitDate;
    }
}

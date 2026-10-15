using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using F10Y.T0002;


namespace F10Y.L0043
{
    /// <summary>
    /// Functions for the MacOS- and Linux-only Nextpad++ (a port of the Windows-only Notepad++).
    /// </summary>
    /// <remarks>
    /// Nextpad++ (<see href="https://nextpad.org/"/>) is an open-source MacOS and Linux port of Notepad++.
    /// </remarks>
    [FunctionsMarker]
    public partial interface INextpadPlusPlusOperator
    {
        /// <summary>
        /// <para>
        /// Returns whether Notepad++ has been installed on the executing machine and if so,
        /// returns the 64-bit executable path, or else the 32-bit path if 32-bit Notepad++ path.
        /// </para>
        /// <para>In any case, the list of checked file path locations is returned.</para> 
        /// </summary>
        /// <remarks>
        /// Whether or not Notepad++ has been installed is determined by whether the expected Notepad++ executable file exists.
        /// </remarks>
        bool Is_NextpadPlusPlusInstalled(
            out string nextpadPlusPlus_ExecutableFilePath,
            out string[] checked_FilePaths)
        {
            checked_FilePaths = Instances.ArrayOperator.From(
                Instances.ExecutableFilePaths.NextpadPlusPlus
            // Try the .local (non-administrator) path as well.
            );

            var administratorInstallation_ExecutableExists = Instances.FileSystemOperator.Exists_File(
                Instances.ExecutableFilePaths.NextpadPlusPlus);

            if (administratorInstallation_ExecutableExists)
            {
                nextpadPlusPlus_ExecutableFilePath = Instances.ExecutableFilePaths.NextpadPlusPlus;

                return true;
            }

            // Try the .local (non-administrator) path as well.
            //var _32bit_ExecutableExists = Instances.FileSystemOperator.Exists_File(
            //    Instances.ExecutableFilePaths.NotepadPlusPlus_Win32);

            //if (_32bit_ExecutableExists)
            //{
            //    notepadPlusPlus_ExecutableFilePath = Instances.ExecutableFilePaths.NotepadPlusPlus_Win32;

            //    return true;
            //}

            // Else
            nextpadPlusPlus_ExecutableFilePath = Instances.Strings.Empty;

            return false;
        }

        string Get_NextpadPlusPlus_ExecutableFilePath()
        {
            var nextpadPlusPlus_IsInstalled = this.Is_NextpadPlusPlusInstalled(
                out var nextpadPlusPlus_ExecutableFilePath,
                out _);

            if (!nextpadPlusPlus_IsInstalled)
            {
                //var checked_FilePathsText =

                Instances.ExceptionOperator.Throw_FileNotFoundException($"The Notepad++ executable was not found.");
            }

            return nextpadPlusPlus_ExecutableFilePath;
        }

        void Open()
        {
            Instances.CommandLineOperator.Run_NoWait(
                Instances.ExecutableFilePaths.NextpadPlusPlus);
        }

        void Open(string filePath)
        {
            var arguments = $"{filePath}";

            Instances.CommandLineOperator.Run_NoWait(
                Instances.ExecutableFilePaths.NextpadPlusPlus,
                arguments);
        }

        void Open(IEnumerable<string> filePaths)
        {
            foreach (var filePath in filePaths)
            {
                this.Open(filePath);
            }
        }

        void Open(params string[] filePaths)
            => this.Open(filePaths.AsEnumerable());

        async Task Write_Lines_AndOpen(
            string textFilePath,
            IEnumerable<string> lines)
        {
            await Instances.FileOperator.Write_Lines(
                textFilePath,
                lines);

            this.Open(textFilePath);
        }
    }
}

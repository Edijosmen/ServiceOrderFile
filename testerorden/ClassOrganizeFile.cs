using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;


namespace testerorden
{
    public class ClassOrganizeFile
    {
        string DumperGameReport = "D:\\Reports\\DumperGameReport";
        string DumperPos = "D:\\Reports\\DumperPos";
        string DumperRedemption = "D:\\Reports\\DumperRedemption";

        public void FuntionOrganize()
        {
            string GR = DumperGameReportMonth(DateTime.UtcNow.Month);
            string PR = DumperPosMonth(DateTime.UtcNow.Month);
            string RD = DumperRedemptionMonth(DateTime.UtcNow.Month);

            OrdenFile(DumperGameReport, GR);
            OrdenFile(DumperPos, PR);
            OrdenFile(DumperRedemption, RD);
        }
        string DumperGameReportMonth(int month)
        {
            string returMonth = "";
            switch (month)
            {
                case 1:
                    returMonth = "01 Ene";
                    break;
                case 2:
                    returMonth = "02 Feb";
                    break;
                case 3:
                    returMonth = "03 Mar";
                    break;
                case 4:
                    returMonth = "04 Abr";
                    break;
                case 5:
                    returMonth = "05 May";
                    break;
                case 6:
                    returMonth = "06 Jun";
                    break;
                case 7:
                    returMonth = "07 Jul";
                    break;
                case 8:
                    returMonth = "08 Ago";
                    break;
                case 9:
                    returMonth = "09 Sep";
                    break;
                case 10:
                    returMonth = "10 Oct";
                    break;
                case 11:
                    returMonth = "11 Nov";
                    break;
                case 12:
                    returMonth = "12 Dic";
                    break;
                default:
                    break;
            }
            return returMonth;
        }
        string DumperPosMonth(int month)
        {
            string returMonth = "";
            switch (month)
            {
                case 1:
                    returMonth = "Ene";
                    break;
                case 2:
                    returMonth = "Feb";
                    break;
                case 3:
                    returMonth = "Mar";
                    break;
                case 4:
                    returMonth = "Abr";
                    break;
                case 5:
                    returMonth = "May";
                    break;
                case 6:
                    returMonth = "Jun";
                    break;
                case 7:
                    returMonth = "Jul";
                    break;
                case 8:
                    returMonth = "Ago";
                    break;
                case 9:
                    returMonth = "Sep";
                    break;
                case 10:
                    returMonth = "Oct";
                    break;
                case 11:
                    returMonth = "Nov";
                    break;
                case 12:
                    returMonth = "Dic";
                    break;
                default:
                    break;
            }
            return returMonth;

        }
        string DumperRedemptionMonth(int month)
        {
            string returMonth = "";
            switch (month)
            {
                case 1:
                    returMonth = "01. ENERO";
                    break;
                case 2:
                    returMonth = "02. FEBRERO";
                    break;
                case 3:
                    returMonth = "03. MARZO";
                    break;
                case 4:
                    returMonth = "04. ABRIL";
                    break;
                case 5:
                    returMonth = "05. MAYO";
                    break;
                case 6:
                    returMonth = "06. JUNIO";
                    break;
                case 7:
                    returMonth = "07. JULIO";
                    break;
                case 8:
                    returMonth = "08. AGOSTO";
                    break;
                case 9:
                    returMonth = "09. SEPTIEMBRE";
                    break;
                case 10:
                    returMonth = "10. OCTUBRE";
                    break;
                case 11:
                    returMonth = "11. NOVIEMBRE";
                    break;
                case 12:
                    returMonth = "12. DICIEMBRE";
                    break;
                default:
                    break;
            }
            return returMonth;
        }
        void OrdenFile(string Report, string Mes)
        {
            try
            {
                string Message = "";
                foreach (string filePath in Directory.GetFiles(Report))
                {
                    string fileName = Path.GetFileName(filePath);
                    if (fileName.Contains("Y0"))
                    {
                        string path = Report + "\\Imperial\\" + DateTime.UtcNow.Year.ToString() + "\\" + Mes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        string fileNameOll = Path.GetFileName(destinationPath);
                        if ( !File.Exists(destinationPath))
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Imperial(OK)";
                        }
                        else
                        {
                            Message += "\n Imperial(Ya Existe)";
                        }
                        
                    }
                    if (fileName.Contains("Y1"))
                    {
                        string path = Report + "\\Salitre\\" + DateTime.UtcNow.Year.ToString() + "\\" + Mes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        string fileNameOll = Path.GetFileName(destinationPath);
                        if (fileName != fileNameOll)
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Salitre(OK)";
                        }
                        else
                        {
                            Message += "\n Salitre(Ya Existe!)";
                        }

                    }
                    if (fileName.Contains("YN"))
                    {
                        string path = Report + "\\Nuestro Bogota\\" + DateTime.UtcNow.Year.ToString() + "\\" + Mes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        string fileNameOll = Path.GetFileName(destinationPath);
                        if (fileName != fileNameOll)
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Nuestro(OK)";
                        }
                        else
                        {
                            Message += "\n Nuestro(Ya Existe!)";
                        }
                    }
                    if (fileName.Contains("YO"))
                    {
                        string path = Report + "\\Diverplaza\\" + DateTime.UtcNow.Year.ToString() + "\\" + Mes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        string fileNameOll = Path.GetFileName(destinationPath);
                        if (fileName != fileNameOll)
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Diverplaza(OK)";
                        }
                        else
                        {
                            Message += "\n Diverplaza(Ya Existe!)";
                        }
                    }
                    if (fileName.Contains("YS"))
                    {
                        string path = Report + "\\Santa Fe\\" + DateTime.UtcNow.Year.ToString() + "\\" + Mes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        string fileNameOll = Path.GetFileName(destinationPath);
                        if (fileName != fileNameOll)
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n SantaFe(OK)";
                        }
                        else
                        {
                            Message += "\n SantaFe(Ya Existe!)";
                        }
                    }
                    if (fileName.Contains("YT"))
                    {
                        string path = Report + "\\Titan\\" + DateTime.UtcNow.Year.ToString() + "\\" + Mes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        string fileNameOll = Path.GetFileName(destinationPath);
                        if (fileName != fileNameOll)
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Titan(OK)";
                        }
                        else
                        {
                            Message += "\n Titan(Ya Existe!)";
                        }
                    }
                    if (fileName.Contains("YW"))
                    {
                        string path = Report + "\\Alegra\\" + DateTime.UtcNow.Year.ToString() + "\\" + Mes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        string fileNameOll = Path.GetFileName(destinationPath);
                        if (fileName != fileNameOll)
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Alegra(OK)";
                        }
                        else
                        {
                            Message += "\n Alegra(Ya Existe!)";
                        }
                    }
                    if (fileName.Contains("YZ"))
                    {
                        string path = Report + "\\Caribe\\" + DateTime.UtcNow.Year.ToString() + "\\" + Mes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        string fileNameOll = Path.GetFileName(destinationPath);
                        if (fileName != fileNameOll)
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Caribe(OK)";
                        }
                        else
                        {
                            Message += "\n Caribe(Ya Existe!)";
                        }
                    }
                }
                EventLog.WriteEntry("FileOrganizerService", "Archivos organizados con éxito Ruta:" + Report+"\n"+Message, EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la organización de archivos
                EventLog.WriteEntry("FileOrganizerService", $"Error al organizar archivos: {ex.Message}", EventLogEntryType.Error);
            }
        }
    }
}

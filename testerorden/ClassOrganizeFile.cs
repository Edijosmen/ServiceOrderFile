using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace testerorden
{
    public class ClassOrganizeFile
    {
        string RutaDumperGameReport = "D:\\Reports\\DumperGameReport";
        string RutaDumperPos = "D:\\Reports\\DumperPos";
        string RutaDumperRedemption = "D:\\Reports\\DumperRedemption";
        string rutaArchivo = "C:\\Logs\\FileOrganizerLog.txt";
        public void FuntionOrganize()
        {
            
           

            OrdenFile( RutaDumperGameReport );
            //OrdenFile(RutaDumperPos);
            //OrdenFile(RutaDumperRedemption);
        }
        string GetMonth(int month)
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
       
        
        void OrdenFile(string Report)
        {
            try
            {
                string Message = "";
                foreach (string filePath in Directory.GetFiles(Report))
                {
                    string fileName = Path.GetFileName(filePath);
                    Match match = Regex.Match(fileName, @"\d{2}-\d{2}-\d{4}");
                    string date = match.Value;
                    string[] datearray = date.Split('-');
                    string day = datearray[0];
                    string month = datearray[1];
                    string year = datearray[2];
                    string nameMes = GetMonth(int.Parse(month));
                    if (fileName.Contains("Y0"))
                    {
                        string path = Report + "\\Imperial\\" + year + "\\" + nameMes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        //validar que no exista el archivo
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
                        string path = Report + "\\Salitre\\" + year + "\\" + nameMes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        //validar que no exista el archivo
                        if (!File.Exists(destinationPath))
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Salitre(OK)";
                        }
                        else
                        {
                            Message += "\n Salitre(Ya Existe)";
                        }

                    }
                    if (fileName.Contains("YN"))
                    {
                        string path = Report + "\\Nuestro Bogota\\" + year + "\\" + nameMes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        //validar que no exista el archivo
                        if (!File.Exists(destinationPath))
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Nuestro(OK)";
                        }
                        else
                        {
                            Message += "\n Nuestro(Ya Existe)";
                        }
                    }
                    if (fileName.Contains("YO"))
                    {
                        string path = Report + "\\Diverplaza\\" + year + "\\" + nameMes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        //validar que no exista el archivo
                        if (!File.Exists(destinationPath))
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Diverplaza(OK)";
                        }
                        else
                        {
                            Message += "\n Diverplaza(Ya Existe)";
                        }
                    }
                    if (fileName.Contains("YS"))
                    {
                        string path = Report + "\\Santa Fe\\" + year + "\\" + nameMes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        //string fileNameOll = Path.GetFileName(destinationPath);
                        //validar que no exista el archivo
                        if (!File.Exists(destinationPath))
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Santafe(OK)";
                        }
                        else
                        {
                            Message += "\n Santafe(Ya Existe)";
                        }
                    }
                    if (fileName.Contains("YT"))
                    {
                        string path = Report + "\\Titan\\" + year + "\\" + nameMes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        //string fileNameOll = Path.GetFileName(destinationPath);
                        if (!File.Exists(destinationPath))
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
                        string path = Report + "\\Alegra\\" + year + "\\" + nameMes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        //string fileNameOll = Path.GetFileName(destinationPath);
                        if (!File.Exists(destinationPath))
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
                        string path = Report + "\\Caribe\\" + year + "\\" + nameMes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        //string fileNameOll = Path.GetFileName(destinationPath);
                        if (!File.Exists(destinationPath))
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Caribe(OK)";
                        }
                        else
                        {
                            Message += "\n Caribe(Ya Existe!)";
                        }
                    }
                    if (fileName.Contains("45"))
                    {
                        string path = Report + "\\San Rafael\\" + year + "\\" + nameMes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        //string fileNameOll = Path.GetFileName(destinationPath);
                        if (!File.Exists(destinationPath))
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Rafael(OK)";
                        }
                        else
                        {
                            Message += "\n Rafael(Ya Existe!)";
                        }
                    }
                    if (fileName.Contains("0A"))
                    {
                        string path = Report + "\\Chipichape\\" + year + "\\" + nameMes + "\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string destinationPath = Path.Combine(path, fileName);
                        //string fileNameOll = Path.GetFileName(destinationPath);
                        if (!File.Exists(destinationPath))
                        {
                            File.Move(filePath, destinationPath);
                            Message += "\n Chipichape(OK)";
                        }
                        else
                        {
                            Message += "\n Chipichape(Ya Existe!)";
                        }
                    }
                }
              

                string contenido = $"[{DateTime.Now}] Archivos organizados con éxito. Ruta: {Report}{Environment.NewLine}{Message}{Environment.NewLine}";

                File.AppendAllText(rutaArchivo, contenido);
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la organización de archivos
                string contenido = $"[{DateTime.Now}] Archivos organizados con éxito. Ruta: {Report}{Environment.NewLine}{ex}{Environment.NewLine}";

                File.AppendAllText(rutaArchivo, contenido);
            }
        }
    }
}

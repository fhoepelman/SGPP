﻿using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BussinessLogic
{
   

        public class ValidarControles
        {

            static ErrorProvider ErrPro = new ErrorProvider();


            //Para Verificar que los Telefonos,Celulares,Fax estan llenado de Forma Correcta
            public void ValidarTelefono(MaskedTextBox Txt, string mensaje)
            {
                Txt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if (Txt.Text.Length != 0 && Txt.MaskFull == false)
                {
                    ErrPro.SetError(Txt, mensaje);
                    Txt.Focus();
                }
                else
                {
                    ErrPro.SetError(Txt, null);
                }

            }

            //Para Verificar que la cedula sea Correcta
            public static bool ValidaCedula(MaskedTextBox Txt)
            {
                string sCedula = Txt.Text;
                int iDigital = 0;
                int p = 0;
                int t = 0;
                int d = 0;
                decimal Resultado = 0;
                int i = 0;
                string sCon = null;

                sCedula = sCedula.Replace("-", "");

                sCedula = sCedula.Trim();

                if (sCedula.Length != 11)
                    return false;

                if (!decimal.TryParse(sCedula, out Resultado))
                    return false;


                iDigital = int.Parse(sCedula.Substring(10, 1));
                sCon = "1212121212";
                p = 0;
                t = 0;
                d = 0;

                for (i = 0; i <= 9; i++)
                {
                    sCedula = sCedula.Trim();
                    p = Convert.ToInt32(sCedula.Substring(i, 1)) * Convert.ToInt32(sCon.Substring(i, 1));
                    if (p > 9)
                    {
                        p = p - 10 + 1;
                    }
                    t = t + p;
                }

                d = (10 - (t % 10)) % 10;
                if (iDigital != d)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            //Para verficiar que los Email esten Escrito Correctamente
            public void ValidarEmail(TextBox Txt)
            {
                if (Txt.Text != string.Empty)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(Txt.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                    {
                        ErrPro.SetError(Txt, null);
                    }
                    else
                    {
                        ErrPro.SetError(Txt, "El E-Mail Esta Incorrecto");
                        Txt.Focus();
                    }
                }
                else
                {
                    ErrPro.SetError(Txt, null);
                }
            }






        }

    }


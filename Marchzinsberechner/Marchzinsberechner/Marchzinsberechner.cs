using System;
using System.Windows.Forms;

namespace Marchzinsberechner
{
    public class Marchzinsberechner
    {
        public double kunde_guthaben;
        public double marchzins;
        public double bonuserhoehung;
        public int geburtagsmonat;
        public string kunde_name;
        public double zins_ohne_bonus;
        public double bonuszinssatzz;
        public double bonuszins;
        public int gtag;
        public double zinssatz;
        public double bonuszinssatz;

        public Marchzinsberechner(double guthaben, double marchzinss, double bonuser, int gebm, string name, int geburtstag)
        {
            kunde_guthaben = guthaben;
            marchzins = marchzinss;
            bonuserhoehung = bonuser;
            geburtagsmonat = gebm;
            kunde_name = name;
            gtag = geburtstag;
        }
         
        public double kompletezinsberechnung()
        {
            bonuszinssatzz = Math.Round(marchzins / 100 * (bonuserhoehung + 100), 2);

            zinssatz = Math.Round(marchzins / 100 + 1, 2);
            zins_ohne_bonus = Math.Round((kunde_guthaben * zinssatz - kunde_guthaben) / 360 * (360 - gtag), 2);
            bonuszinssatz = Math.Round((zinssatz - 1) / 100 * (bonuserhoehung + 100) + 1, 2);
            bonuszins = Math.Round((kunde_guthaben * bonuszinssatz - kunde_guthaben) / 360 * gtag, 2);
            return Math.Round(zins_ohne_bonus + bonuszins, 2);
        }

        public string marchzinsberechnung(int vontag, int vonmonat, int bistag, int bismonat, int geburtstagsmonat, int geburtstags_tag)
        {
            int monattagedifferenz;
            int tagesdifferenz = (30 - vontag) + bistag;
            int totaltage;
            int bonustage;
            double totalerzins;
            //gesamte tage werden ermittelt
            if (vonmonat < bismonat)
            {
                monattagedifferenz = (((bismonat-1) * 30) - ((vonmonat-1) * 30));
                 totaltage = monattagedifferenz + tagesdifferenz;    
            }else if(bismonat < vonmonat)
            {
                monattagedifferenz = 330 -  (((vonmonat - 1) * 30) - ((bismonat - 1)*30));
                 totaltage = monattagedifferenz + tagesdifferenz;
            }
            else
            {
                totaltage = bistag - vontag;
            }

            //geburtstagstage dazwischen werden ermittelt
            if(vonmonat<=geburtstagsmonat && bismonat >= geburtstagsmonat )
            {
                if(geburtstagsmonat == bismonat && geburtstagsmonat == vonmonat)
                {
                    if (bistag <= geburtstags_tag)
                    {
                        bonustage = geburtstags_tag- vontag;

                    }else if(vontag > geburtstags_tag)
                    {
                        bonustage = 0;
                    }
                    else
                    {
                        bonustage = (bistag - (bistag - geburtstags_tag)) - vontag;
                    }
                }
                else if(geburtstagsmonat == bismonat)
                {
                    if(bistag <= geburtstags_tag)
                    {
                        bonustage = geburtstags_tag;
                       
                    }
                    else
                    {
                        bonustage = bistag - (bistag - geburtstags_tag);
                    }
                }
                else
                {
                    bonustage = geburtstags_tag;
                }

                 

            }
            else
            {
                bonustage = 0;
            }
            totaltage = totaltage - bonustage;

            //berechnung der zinsen
            zins_ohne_bonus = Math.Round((kunde_guthaben * zinssatz - kunde_guthaben) / 360 * (totaltage), 2);
            bonuszins = Math.Round((kunde_guthaben * bonuszinssatz - kunde_guthaben) / 360 * bonustage, 2);
            totalerzins = Math.Round(zins_ohne_bonus + bonuszins, 2);

            return $"Totaler Zins in der Zeitperiode: {totalerzins} \n Anteil normaler Zins: {zins_ohne_bonus} \n Anteil Bonuszins: {bonuszins} \n Nettozins 65%: {Math.Round(totalerzins / 100 * 65, 2)}" +
                $"\n total Verrechnungssteuer {Math.Round(totalerzins / 100 * 35, 2)} \n Verrechnungssteuer des Bonuszins {Math.Round(bonuszins / 100 * 35, 2)}";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
    class Combat
    {
        private Reptilien masterReptilien;
        private Rider masterRider;
        private Rider masterRider2;
        private Reptilien masterReptilien2;
        private Master gagnant;
        private int choix;
        private bool estRider = true;
        private AffichageCombat afficher;
        private int nbCoups;
        private bool fin = false;

        public Combat(Reptilien masterReptilien, Rider masterRider, bool estRider)
        {
            this.masterReptilien = masterReptilien;
            this.masterRider = masterRider;
            choix = 1;
            this.estRider = estRider;
            afficher = new AffichageCombat();
            nbCoups = 0;
        }

        public Combat(Reptilien masterReptilien, Reptilien masterReptilien2)
        {
            this.masterReptilien = masterReptilien;
            this.masterReptilien2 = masterReptilien2;
            choix = 2; 
            afficher = new AffichageCombat();
            nbCoups = 0;
        }

        public Combat(Rider masterRider, Rider masterRider2)
        {
            this.masterRider = masterRider;
            this.masterRider2 = masterRider2;
            choix = 3;
            afficher = new AffichageCombat();
            nbCoups = 0;
        }

        public void Start()
        {

            if (choix == 1 && estRider == true)
            {
                afficher.Apparition(masterReptilien);
            }
            else if (choix == 1 && estRider == false)
            { 
                afficher.Appartion(masterRider2);
            }
            else if (choix == 2)
            {
                afficher.Apparition(masterReptilien2);
            }
            else
            { 
                afficher.Appartion(masterRider2);
            }


            if (choix == 1 && estRider == true)
            {
                while (fin == false)
                {
                    masterReptilien.MontureR.Vie -= ((masterRider.MontureA.Attaque) + (masterRider.ArmeRider.Att));
                    afficher.CoupRiderReptile(masterReptilien);
                    nbCoups += 1;
                    if (masterReptilien.MontureR.Estvivant() == false)
                        fin = true;
                    if (fin == false)
                    { 
                        masterRider.MontureA.Vie -= ((masterReptilien.MontureR.Attaque) + (masterReptilien.ArmeReptilien.Att));
                        afficher.CoupReptileRider(masterRider);
                        if (masterRider.MontureA.Estvivant() == false)
                            fin = true;
                    }
                }
                if (masterRider.MontureA.Estvivant() == true)
                {
                    afficher.EstMort(masterReptilien);
                    afficher.EstGagnant(masterRider);
                }
                else
                {
                    afficher.EstMort(masterRider,nbCoups);
                    afficher.EstGagnant(masterReptilien);
                }
                    gagnant = masterReptilien;
            }
            else if(choix == 1 && estRider == false)
            {
                while (fin==false)
                {
                    masterRider.MontureA.Vie -= ((masterReptilien.MontureR.Attaque) + (masterReptilien.ArmeReptilien.Att));
                    afficher.CoupReptileRider(masterRider);
                    nbCoups += 1;
                    if (masterRider.MontureA.Estvivant() == false)
                        fin = true;
                    if (fin == false)
                    {
                        masterReptilien.MontureR.Vie -= ((masterRider.MontureA.Attaque) + (masterRider.ArmeRider.Att));
                        afficher.CoupRiderReptile(masterReptilien);
                        if (masterRider.MontureA.Estvivant() == false)
                            fin = true;
                    }
                }

                if (masterReptilien.MontureR.Estvivant() == true)
                {
                    afficher.EstMort(masterReptilien);
                    afficher.EstGagnant(masterRider);
                }
                else
                {
                    afficher.EstMort(masterRider,nbCoups);
                    afficher.EstGagnant(masterReptilien);
                }
                    
            }
            else if (choix == 2)
            {
                while(fin==false)
                {
                    masterReptilien2.MontureR.Vie -= ((masterReptilien.MontureR.Attaque) + (masterReptilien.ArmeReptilien.Att));
                    afficher.CoupReptileReptile(masterReptilien2);
                    nbCoups += 1;
                    if (masterReptilien2.MontureR.Estvivant() != true)
                        fin = true;
                    if (fin == false)
                    { 
                        masterReptilien.MontureR.Vie -= ((masterReptilien2.MontureR.Attaque) + (masterReptilien2.ArmeReptilien.Att));
                        afficher.CoupReptileReptile(masterReptilien);
                        if (masterReptilien2.MontureR.Estvivant() != true)
                            fin = true;
                    }
                }

                if (masterReptilien.MontureR.Estvivant() == true)
                {
                    afficher.EstMort(masterReptilien2);
                    afficher.EstGagnant(masterReptilien);
                }
                else
                {
                    afficher.EstMort(masterReptilien);
                    afficher.EstGagnant(masterReptilien2);
                }
            }
            
            else
            {
                while(fin==false)
                {
                    masterRider2.MontureA.Vie -= ((masterRider.MontureA.Attaque) + (masterRider.ArmeRider.Att));
                    afficher.CoupRiderRider(masterRider2);
                    nbCoups += 1;
                    if (masterRider.MontureA.Estvivant() == false)
                        fin = true;
                    if (fin == false)
                    { 
                        masterRider.MontureA.Vie -= ((masterRider2.MontureA.Attaque) + (masterRider2.ArmeRider.Att));
                        afficher.CoupRiderRider(masterRider);
                        if (masterRider.MontureA.Estvivant() ==false)
                            fin = true;
                    }
                }

                if (masterRider.MontureA.Estvivant() == true)
                {
                    afficher.EstMort(masterRider2,nbCoups);
                    afficher.EstGagnant(masterRider);
                }

                else
                {
                    afficher.EstMort(masterRider,nbCoups);
                    afficher.EstGagnant(masterRider2);
                }
            }

        }
    }
}

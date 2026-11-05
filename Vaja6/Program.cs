using System.IO;

namespace vaja6 {

  // Enumerator za tip poklica
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {
		// id igralca
        private int id;
		// ime igralca
        private string u_ime;
		// geslo igralca
        private string u_geslo;
		// stevilo igralcev
        private static int stIg = 1;

		// privzeti konstruktor za igralca
        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

		// lastnost ki dovoli le branje
        public int Id {
            get
            {
                return id;
            }
        }

		// lastnost, ki dovoli branje in nastavljanje imena
        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }
		
		// lastnost ki dovoli branje in nastavljanje imena
        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

		// lastnost ki vrne stevilo igralcev
        public static int StIg
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}

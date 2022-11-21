using System.Runtime.Serialization;
namespace Models
{
    [DataContract]
    public class Vergelijking{
        private string _wiskunde;
        [DataMember]
        public string Wiskunde {
            get => _wiskunde;
            set {
                _wiskunde = value;
            }
        }

        public Vergelijking(string wiskunde){
            this.Wiskunde = wiskunde;
        }

        public string afleiding(){
            return "afleiding( " + this.Wiskunde + " )";
        }
    }
}
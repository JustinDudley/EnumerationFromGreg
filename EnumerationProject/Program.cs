using System;

namespace EnumerationProject {

    enum GradStatus { SummaCumLaude, MagnaCumLaude, CumLaude }

    class Program {
        static void Main(string[] args) {

            GradStatus gs = GradStatus.MagnaCumLaude;
            var i = (int)gs;

            if(gs == GradStatus.MagnaCumLaude) {

            }

        }
    }
}

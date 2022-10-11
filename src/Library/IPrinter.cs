using System;

namespace Full_GRASP_And_SOLID.Library;
    public interface IPrinter
    {
         public void PrintRecipe(Recipe recipe);
    }
/*se crea la interfaz IPrinter para que luego las clases ConsolePrinter y 
FilePrinter la implementen y que cuando
 se haga desde el program se ejecte
una u otra dependiento del destino, todo esto usando el principio LSP*/
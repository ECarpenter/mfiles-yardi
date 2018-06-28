using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mFile_Yardi
{
    class export
    {
        //
        //
        // pseudo code for pulling invoice data out of mFiles
        //
        //

        //connect to mFiles

        //open vault

        //pull up invoices

        //loop through invoices collecting at import workflow state

            //add data to xml object

            //change workflow state 
        
        //End Loop

        //combine xaml objects

        //save export file
    }

    class import
    {
        //
        //
        //Pseudo code for importing check data from yardi
        //
        // 


        //connect to mFiles

        //open vault

        //open XML file

        //loop through items

            //find mFiles object with matching invoice number

            //add check number to mFiles Object

            //change state to complete

        //End Loop

    }
}

/// Chapter No. 11		Exercise No. 1
/// File Name: Document.cs , Email.cs , File.cs
/// @author: Chester Brock 
/// Date:  Nov 23, 2021
///
/// Problem Statement: Create 2 classes to derive from a document class
/// 
/// 
/// Overall Plan:
/// 1) Define a class named Document that contains an instance variable of type string named text that stores any textual content for the document.
/// 2) Create a method named ToString() that returns the text field and also include a method to set this value.
/// 3) define a class for Email that is derived from Document and includes instance variables for the sender, recipient, and title of an email message.
/// 4) Implement appropriate setter and getter methods
/// 5) The body of the email message should be stored in the inherited variable text.
/// 6) Redefine the ToString() method to concatenate all text fields.
/// 7) define a class for File that is derived from Document and includes a instance variable for the pathname
/// 8) The textual contents of the file should be stored in the inherited variable text. Redefine the ToString() method to concatenate all text fields.
/// 9) create 2 Email and Fileobjects (4 total objects) in your Main method.  
/// 10) Test your object by pass them to the following subroutine that returns true if the object contains the specified keyword in the text property.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Lab
{
    class Document
    {
        // instance variable 
        private string anyText;

        public Document(string anyText)
        {
            this.anyText = anyText;
        }

        public string AnyText { get => anyText; set => anyText = value; }

        // methods
        public string toString()
        {
            return "Message : " + this.AnyText;
        }
    }
}



    //פונקציות לבדיקת טופס

    //פונקציה ראשית
    function ValidReg()
    {
        var oksur = ValidSurName();
        var okname = ValidName();
        var okuser = ValidUser();
        var okpass = ValidPass();
        if ((okname)&&(okusname) && (okuser) && (okpass))
            return true;
        else
            return false;
            alert("There were some problems");
    }




    //פונקציות כלליות לשימוש בפונקציות אחרות

    //מחזיר אמת כאשר הערך המועבר מכיל רק אותיות
    function isWord(str) 
    {
        var count = 0;
        for (i = 0; i < str.length; i++)
            if (isNaN(str.charAt(i)))
                count++;
        if (count == str.length)
            return true;
        else
            return false;
    }

    //מחזירה אמת אם המחרוזת מכילה סימן מיוחד
    function hasSymbols(str) 
    {
        var symbols = "!@#$%^&*()+=|\/'<>{}[]"; //מחרוזת המכילה את כל הסימנים
        for (i = 0; i < str.length; i++) //עבור כל אות במחרוזת הנבדקת 
            if (symbols.indexOf(str.charAt(i)) != -1) //אם האות מופיעה במחרוזת הסימנים
                return true; //תחזיר אמת
        return false;
    }
    //בדיקות שם 
    // מכיל לפחות 2 אותיות. אינו מכיל ספרות. אינו מכיל סימנים מיוחדים
  
    function ValidSurName() 
    {
        var name = document.getElementById("srnm").value;
        var errmsg = "";
        if (name.length < 2)
            errmsg += "השם חייב להכיל לפחות שתי אותיות" + "<br/>";
        if (hasSymbols(name) == true)
            errmsg += "השם אינו יכול להכיל סימנים מיוחדים" + "<br/>";
        var nospace = name.replace(" ", ""); //מוריד רווחים
        nospace = nospace.replace("-", ""); //מוריד קו מפריד
        if (isWord(nospace) == false)
            errmsg += "השם חייב להכיל רק אותיות" + "<br/>";
        document.getElementById("srn").innerHTML = errmsg; //מציב את ערך השגיאה במקום המתאים. אם אין, תוצב מחרוזת ריקה
        if (errmsg == "")
            return true;
        else
            return false;
    }
    function ValidName() 
    {
        var name = document.getElementById("nm").value;
        var errmsg = "";
        if (name.length < 2)
            errmsg += "השם חייב להכיל לפחות שתי אותיות" + "<br/>";
        if (hasSymbols(name) == true)
            errmsg += "השם אינו יכול להכיל סימנים מיוחדים" + "<br/>";
        var nospace = name.replace(" ", ""); //מוריד רווחים
        nospace = nospace.replace("-", ""); //מוריד קו מפריד
        if (isWord(nospace) == false)
            errmsg += "השם חייב להכיל רק אותיות" + "<br/>";
        document.getElementById("n").innerHTML = errmsg; //מציב את ערך השגיאה במקום המתאים. אם אין, תוצב מחרוזת ריקה
        if (errmsg == "")
            return true;
        else
            return false;
    }

    //בדיקת שם משתמש
    //מכיל לפחות 5 אותיות. אינו מכיל סימנים מיוחדים ורווחים
    function ValidUser()
     {
        var name = document.getElementById("id").value;
        var errmsg = "";
        if (name.length < 5)
            errmsg += "שם משתמש חייב להכיל לפחות 5 אותיות" + "<br/>";
        if (hasSymbols(name) == true)
            errmsg += "שם המשתמש אינו יכול להכיל סימנים מיוחדים" + "<br/>";
        var nospace = name.replace(" ", ""); //מוריד רווחים
        if (name != nospace)
            errmsg += "לא ניתן להשתמש ברווחים בשם משתמש" + "<br/>";
        document.getElementById("usern").innerHTML = errmsg;
        if (errmsg == "")
            return true;
        else
            return false;
    }
    //בדיקת סיסמא
    // לפחות 4 תווים. ללא רווחים. חייב להכיל אותיות וספרות
    function ValidPass() 
    {
        var pass = document.getElementById("pswr").value;
        var errmsg = "";
        if (pass.length <4)
            errmsg += "הסיסמא  חייבת להכיל לפחות 4 אותיות" + "<br/>";
        var nospace = pass.replace(" ", ""); //מוריד רווחים
        if (pass != nospace)
            errmsg += "לא ניתן להשתמש ברווחים בסיסמא" + "<br/>";
        var chars = 0;
        var digits = 0;
        for (i = 0; i < pass.length; i++) //מניית הספרות והאותיות
            if (isNaN(pass.charAt(i)))
                chars++;
            else
                digits++;
        if ((chars == 0) || (digits == 0)) //אם אין אף אות או אף ספרה
            errmsg += "הסיסמא חייבת להכיל ספרות ואותיות" + "<br/>";
        document.getElementById("pass").innerHTML = errmsg;
        if (errmsg == "")
            return true;
        else
            return false;
    }
  
   
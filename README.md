# Q1-twitterTower

מערכת לחקירת מגדלים שונים (עבור חברת טוויטר), המערכת בונה אובייקטים מסוג משולש או מלבן ע"פ דרישת המשתמש וכן מקבלת מהמשתמש את רוחבו וגובהו של הבניין הנדרש לו ומאפשרת ביצוע פעולות על המגדל כגון: חישוב שטח והיקף וכן הדפסה של אובייקטים מסוג  מגדל מלבן או מגדל משולש.
המערכת בנויה בסגנון תבנית העיצוב:factory method המפשיטה למשתמש את השימוש במערכת וחוסכת לו את ההבנה בצורת הבנייה השונה של כל אובייקט כאשר על המשתמש מוטלת המשימה לבחור את סוג האובייקט הנדרש לו ואת פרטי המגדל המתאימים בלבד והמפעל אחראי לייצר לו אובייקט כפי בקשתו וכן לאפשר לו את הפעולות המתאימות לאובייקט שביקש ליצור.

# אופן השימוש:
המערכת מאפשרת למשתמש לבחור ביצירת אובייקט מסוג משולש, בלחיצה על 1 או אובייקט מסוג מלבן בלחיצה על 2 בהרצת התוכנית וכן מבקשת מהמשתמש להכניס את רוחבו וגובהו של המגדל הנדרש.
עבור מגדל מסוג משולש:
![image](https://github.com/ruth-katzir/Q1-twitterTower/assets/133040769/72d72cce-cce3-4042-ae5f-07b2d64b97f6)

עבור מגדל מסוג מלבן:
![image](https://github.com/ruth-katzir/Q1-twitterTower/assets/133040769/fff9e914-38db-41f3-84d0-1b053aa5f38a)

עבור מגדל מסוג מלבן , המערכת בוחרת ע"פ קריטריונים מוגדרים מראש המבוססים על פרטי המגדל האם להדפיס למשתמש את היקפו או שטחו של המגדל המבוקש:
![image](https://github.com/ruth-katzir/Q1-twitterTower/assets/133040769/b723a47e-1e3d-4a05-a14a-fe25dcd0b8fd)

עבור מגדל מסוג משולש, המערכת נותנת למשתמש לבחור האם להדפיס את שטחו של המשולש או להדפיס את סימולציית המשולש, ע"פ קריטריונים מובנים מראש במערכת בהתבסס על רוחבו וגובהו של המגדל, לדוג':
![image](https://github.com/ruth-katzir/Q1-twitterTower/assets/133040769/23941cd9-6190-4052-8cb6-591c65ed9471)

המערכת תאפשר למשתמש ליצור אובייקטים נוספים עד שיבחר ב- 3 ליציאה מהתוכנית.

# תלויות חיצוניות: 
The basic dependencies you'll have are the .NET Framework libraries. These libraries come pre-installed with the .NET development environment. you need that libaries to use that project:

1. .NET Framework: The .NET Framework provides a comprehensive set of libraries and runtime components for building and running applications on Windows. It includes libraries for common functionalities like file I/O, networking, data access, and more.

2. System namespace: The System namespace is part of the .NET Framework and contains fundamental classes and base types that are used in most .NET applications. It includes classes for handling strings, collections, exceptions, input/output, and more.

3. System.IO namespace: The System.IO namespace provides classes for working with input and output operations, including file and directory manipulation, stream handling, and reading/writing data.

These are the core dependencies that come with the .NET Framework and are available by default in Visual Studio for C# projects.

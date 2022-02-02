    static var myLog : String;
    private var output : String = "";
    private var stack : String = "";
     
    function OnEnable () {
    Application.RegisterLogCallback(HandleLog);
    }
     
    function OnDisable () {
    // Remove callback when object goes out of scope
    Application.RegisterLogCallback(null);
    }
     
    function HandleLog (logString : String, stackTrace : String, type : LogType) {
    output = logString;
    stack = stackTrace;
    myLog +="\n"+output;
    }
     
    function OnGUI () {
    myLog = GUI.TextArea (Rect (10, 10, Screen.width-10, Screen.height-10), myLog);
    }
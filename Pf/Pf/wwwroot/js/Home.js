
////let fn = Document.getElementbyId('fn')

////console.log(fn.value)

////    Document.getElementbyId('ln')
////    Document.getElementbyId('pw')
////    Document.getElementbyId('zc').value

////console.log(fn)

////let form = document.getElementByClassName('col-lg-4');

////ChangeFormValues function(form) {
////    form.parentSudeo
////};

////Window.Document.onload( testingAccesstostorage )();
////function testingAccesstostorage()

////if ( typeof ( Storage ) !== "undefined" )
////{
////		window.alert( 'testing to see if we can get access to local storage' );
////	} else
////	{
////		window.alert( "Bad news your gonna have to find another way ahah" );
////	}

////check passed we are good
////check if funciton call is working on button
//function ChangeFormValues()
//{
//	console.log('clicked happened' );
////	window.alert('all clear')
//}//passed
//let sendFormData = new FormData();
////get values from form add them to form data for request
//document.querySelector( 'homeLoginbtn' ).addEventListener( onclick, ( e ) =>
//{
//	e.preventDefault;
//	var elements = document.getElementById( "myForm" ).elements;
//	var obj = {};
//	for ( var i = 0; i < elements.length; i++ )
//	{
//		var item = elements.item( i );
//		obj[item.name] = item.value;
//		console.log( obj );
//	}
//}
document.getElementById( "homeLoginbtn" ).addEventListener( "submit", ( event ) =>
{
	event.preventDefault();
});
//	////let loginUserName = document.getElementById( "UserName" ).value;
//	//let formUserName = document.getElementById( "LoginHome" ).elements[0].value;
//	//console.log( UserName.val );
//	//console.log( formUserName);
//	////let loginPassword = $( '#Password' ).val()
//	//console.log( Password );
//	//sessionStorage.setItem( "User", "loginUserName ");
//	//sessionStorage.setItem(" UserPassWord", "loginPassword ");
//	//having issues with forms jsut gonna looop through its length

//	let formUserName = document.getElementById( "LoginHome" ).elements[0].value;
//	let formPassword= document.getElementById( "LoginHome" ).elements[1].value;
//	console.log( formPassword );
//	console.log(formUserName );
//} );

////function myFunction()
////{
////	var elements = document.getElementById( "myForm" ).elements;
////	var obj = {};
////	for ( var i = 0; i < elements.length; i++ )
////	{
////		var item = elements.item( i );
////		obj[item.name] = item.value;
////	}

//////	document.getElementById( "demo" ).innerHTML = JSON.stringify( obj );
//////}

//	let loginUserName = document.getElementById( "UserName" ).value;
//	console.log( loginUserName );

////console.log(sessionStorage[1].value );
//var form = document.querySelector( 'form' );
//var data = new FormData( form );
//var req = new XMLHttpRequest();
//req.send( data );

//changed name of login button is what caused all thiss..
//document.getElementById("homeLoginbtn").addEventListener( "click", function( event )
//{
//	event.preventDefault()
//	let formUserName = "";
//	let formPassword = "";
//	 formUserName = document.querySelector( "form" ).elements[0].value;
//	formPassword = document.querySelector( "form" ).elements[1].value;



	//while ( ( formUserName === "" ) && formPassword === "" );{

	//let formUserName = document.querySelector( "form" ).elements[0].value;
	//	let formPassword = document.querySelector( "form" ).elements[1].value;
	//} 
	//console.log("form" );



	//UserInfo = new Object();

	//UserInfo.UserName = formUserName.toString();
	//Userinfo.Password = formPassword.toString();


	//console.log( UserInfo.formUserName);
	//window.sessionStorage.setItem( 'formUserName', '' );
//} );


	//let formUserName = document.getElementById( "LoginHome" ).elements[0].value;
	//let formPassword = document.getElementById( "LoginHome" ).elements[1].value;


//let formUserName = document.getElementById( "form" ).elements[0].value;
//let formPassword = document.getElementById( "LoginHome" ).elements[1].value;
////let formUserName = document.getElementById( "LoginHome" ).elements[0].value;
////let formPassword= document.getElementById( "LoginHome" ).elements[1].value;
//function getlogininfo(){
//	let formUserName = document.getElementById( "LoginHome" ).elements[0].value;
//	let formPassword = document.getElementById( "LoginHome" ).elements[1].value;
//	console.log( formPassword );
//	console.log( formUser );
//}

//// Save data to sessionStorage
//sessionStorage.setItem( 'key', 'value' );

//// Get saved data from sessionStorage
//var data = sessionStorage.getItem( 'key' );

//// Remove saved data from sessionStorage
//sessionStorage.removeItem( 'key' );

//// Remove all saved data from sessionStorage
//sessionStorage.clear();

function store()
{
	console.log( sessionStorage.length );
	var inputUser = document.getElementById( "UserName" );
	sessionStorage.setItem( "UserName", inputUser.value );
	console.log( sessionStorage.length );
	var inputPassWord = document.getElementById( "Password" );
	sessionStorage.setItem( "Password", inputPassWord.value );
	console.warn(sessionStorage.length );
};

if


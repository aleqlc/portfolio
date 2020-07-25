Auth.Demo : docker실행이안됨

AuthRegisterSignIn : 받은자료. 실행잘됨. postman으로 User등록할 때 에러뜸. DB에 직접 User입력 후 동작. 

BlazorJWTAuth : Blazor server app템플릿, Blazor UI를 통해 id와 pass입력하고 버튼누르면 계속해서 새로운 token생성. API 사용안했기때문에 postman으로 토큰GET불가

CoreJwtExample2 : CRUD 모두 실행됨. Core, API, Dapper사용, 인증받았을때만 CRUD가 동작, postman은 다 되는데 브라우저에서 토큰이 안얻어짐, 동작영상있음

CreateJWT : Core, API사용, postman이나 브라우저에서 user, pass같이 보내면 Token얻어짐(Get메서드), Post메서드가 동작안함

JWTAuthDemo : 실행잘됨. Core, API사용.  crud는 아직없음. 동작영상있음

WebAPIMvcJWT : .NETFramework, API, MVC사용, 브라우저에서 Token은 얻어지는데 postman에서 NullReferenceException뜸


Token 인증과 관련한 프로젝트들이며, 모두 별개의 프로젝트들입니다.
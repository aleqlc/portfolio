ConvertToDapper프로젝트<br/>
1.Entityframework로 접근했던 EmployeeAPIDB에 Dapper로 접근하였습니다.<br/>
2.DTO, Controller, Repository 세 개의 클래스에 로직작성.<br/>
3.CRUD모두 동작됩니다.<br/><br/>

DapperAPIandSProcedure프로젝트<br/>
1.Dapper, WebAPI, 저장프로시저를 사용.<br/>
2.interface, enum, Global사용.<br/>
3.CRUD모두 동작됩니다.<br/><br/>

DapperCRUDAPI프로젝트<br/>
1.Dapper, WebAPI만을 사용.<br/>
2.DTO, Controller, Repository 세 개의 클래스에 로직작성.<br/>
3.CRUD모두 동작됩니다.<br/><br/>

DapperUsingMultiQueriesObjects프로젝트<br/>
1.Dapper의 multiQuery기능과 object를 이용하여 두 개의 테이블에 동시에 데이터를 입력, 검색, 수정, 삭제할 수 있습니다.<br/>
2.WebAPI, 저장프로시저 사용. interface, Global사용<br/>
3.CRUD모두 동작되지만 PUT할 때 URL과 Json에 모두 id값을 부여해줘야 update가 됩니다.<br/><br/>

모두 별개의 프로젝트들입니다.
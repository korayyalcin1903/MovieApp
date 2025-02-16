export class SessionStorageService{
 
  constructor () {    
  }

  public getAccessToken (): string | null {
    return localStorage.getItem("accessToken");
  }
  
  public setAccessToken (accessToken:any) {
    return localStorage.setItem("accessToken", accessToken);
  }

  public setUserInfo (userInfo:any) {
    return sessionStorage.setItem("userInfo", JSON.stringify(userInfo));
  }

  public getUserInfo ():any {
    return JSON.parse(sessionStorage.getItem('userInfo') as any);
  }
  public clearAll () {
    localStorage.clear();
    sessionStorage.clear();
  }
} 

export default new SessionStorageService();
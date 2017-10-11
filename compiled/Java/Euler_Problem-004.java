/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABACNUMtqw0AM/JUBbS82TkdOFoowJh9i4t72qtOe8vHRuqXkYULnIMTMrjQjNSrNPef81XUdTz4ri/ZmSuepDGTBInUNivQlaRMWaxKCTonHcjjjBZe/"+
                                 "riJNv+2sAgqiuqATmKAKMN39q2uVoehQxrARuzWayUfqVNeL2Gefsyt7DdFb+QjCHkc0JMwcWw6ODioKBlx/PLx63XONvcebPFtEXr4jPI9e3037z5btNny2v4MbijFY"+
                                 "E6oBAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[426];for(int i=0;i<426;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<71&&y<6)?g[(int)(y*71+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<71&&y<6)g[(int)(y*71+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(0,0,1);
    gw(1,0,1);
    gw(0,4,1000);
    return 1;
}
private int _1(){
    sa(gr(1,0)+1);
    t0=gr(1,0)+1;
    gw(1,0,gr(1,0)+1);
    t0-=gr(0,4);
    sa(gr(0,0));

    if((t0)!=0)return 3;else return 2;
}
private int _2(){
    sa(sp()+1L);

    sa(sr());
    gw(0,0,sp());
    gw(1,0,1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sp();
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}

    if(sr()!=gr(0,4))return 3;else return 12;
}
private int _3(){
    gw(0,1,1);
    sa(sp()*sp());

    sa(sr());
    return 4;
}
private int _4(){
    t0=tm(sr(),10);
    gw(gr(0,1),1,t0);
    gw(0,1,gr(0,1)+1);
    sa(td(sp(),10));

    sa(sr());
    return 5;
}
private int _5(){
    if(sp()!=0)return 4;else return 6;
}
private int _6(){
    gw(0,2,1);
    sp();
    return 7;
}
private int _7(){
    if(gr(gr(0,2),1)!=gr(gr(0,1)-gr(0,2),1))return 10;else return 8;
}
private int _8(){
    t0=gr(0,2)+1;
    gw(0,2,gr(0,2)+1);
    t0-=gr(0,1);

    if((t0)!=0)return 7;else return 9;
}
private int _9(){
    if(sr()<gr(0,3))return 10;else return 11;
}
private int _10(){
    sp();
    return 1;
}
private int _11(){
    gw(0,3,sp());
    return 1;
}
private int _12(){
    System.out.print(String.valueOf(gr(0,3))+" ");
    sp();
    sp();
    return 13;
}

public void main(){
    int c=0;
    while(c<13){
    switch(c){
    case 0:c=_0();break;
    case 1:c=_1();break;
    case 2:c=_2();break;
    case 3:c=_3();break;
    case 4:c=_4();break;
    case 5:c=_5();break;
    case 6:c=_6();break;
    case 7:c=_7();break;
    case 8:c=_8();break;
    case 9:c=_9();break;
    case 10:c=_10();break;
    case 11:c=_11();break;
    case 12:c=_12();break;
}
}
}
public static void main(String[]a){new Program().main();}
}

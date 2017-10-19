/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABACVjr0OgzAMhF8lUsriiGID4ecURX2QCMasnjLx8A2dWqoO9XLW2b7PxfxRUcCsQhDWntCzDoSBdSSMrJ5Q3paLivBNeQWtygtoUZ5Bs/IEmpR9+Mov"+
                                 "e7G/6Wgl1EwT4sp5pghwivDeNZxTlQ627NHZkGDD7trjPHKvv4f2fnuYA53zPmVuqsB88CNE8nZ2Wxapo3jFb1fjCcDxR0M7AQAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[315];for(int i=0;i<315;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<45&&y<7)?g[(int)(y*45+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<45&&y<7)g[(int)(y*45+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(0,0,1);
    gw(1,0,1);
    gw(2,0,2);
    gw(3,0,6);
    gw(4,0,24);
    gw(5,0,120);
    gw(6,0,720);
    gw(7,0,5040);
    gw(8,0,40320);
    gw(9,0,362880);
    gw(1,1,0);
    t0=362880;
    sa(gr(9,0)*7);
    sa(gr(9,0)*7);
    sa(0);
    sa(gr((gr(9,0)*7)%10,0));
    sa((gr(9,0)*7)/10);
    sa((gr(9,0)*7)/10);
    return 1;
}
private int _1(){
    if(sp()!=0)return 2;else return 3;
}
private int _2(){
    sa(gr(sr()%10,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()/10L);

    sa(sr());

    if(sp()!=0)return 10;else return 3;
}
private int _3(){
    sa(sp()+sp());

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 9;else return 4;
}
private int _4(){
    sa(sp()+sp());

    t0=sp();
    sa(sp()-t0);

    t1=sp();

    if((t1)!=0)return 5;else return 8;
}
private int _5(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 6;else return 7;
}
private int _6(){
    sa(sr());
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(gr(sr()%10,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()/10L);

    sa(sr());
    return 1;
}
private int _7(){
    System.out.print(String.valueOf(gr(1,1)-3)+" ");
    sa(sr());
    sp();
    sp();
    return 11;
}
private int _8(){
    gw(1,1,sr()+gr(1,1));
    return 5;
}
private int _9(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 3;
}
private int _10(){
    sa(gr(sr()%10,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()/10L);

    sa(sr());
    return 1;
}

public void main(){
    int c=0;
    while(c<11){
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
}
}
}
public static void main(String[]a){new Program().main();}
}

/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtUbsOgzAM/JXwWhpRnAEGy4r6IVFBaqWsTJn4+NpFPAW0Hdh6g2X5nPPFjp+xgRYAWmvAI4DXnJsck1CnwJSNH7EwaDReHJaoM8ehqHTbcI/qEWx6"+
                                 "vfXpXc3QgqGN8sRq48EoGirwjnajd41wTHcROup4QG6QJ1Ca1iGJ0Ouq0Fi6jIPUFZK44D9qkgbOMRdLJJkHcmKdFtK22TDIqzh0NL1YtIV87Wg2y/I1hnxYXzLimyXN"+
                                 "X678jljaBLn1/Mgf9ryj8zNWOtumBaRolzvPz1/nJJ0XFH7TnYAEAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1152];for(int i=0;i<1152;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<72&&y<16)?g[(int)(y*72+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<72&&y<16)g[(int)(y*72+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(1,0,100);
    gw(0,0,0);
    return 1;
}
private int _1(){
    t0=gr(1,0)-1;
    t1=gr(1,0)-1;
    gw(0,0,gr(1,0)+gr(0,0));

    if((t1)!=0)return 17;else return 2;
}
private int _2(){
    gw(1,0,0);
    return 3;
}
private int _3(){
    t0=99>gr(1,0)?1:0;
    gw(gr(1,0)%10,(gr(1,0)/10)+6,(gr(1,0)+1)*(gr(1,0)+1));

    if((t0)!=0)return 16;else return 4;
}
private int _4(){
    sa(gr(0,0));
    gw(1,0,gr(0,0));
    return 5;
}
private int _5(){
    t0=gr(1,0)-1;
    gw(1,0,gr(1,0)-1);

    if((t0)!=0)return 15;else return 6;
}
private int _6(){
    gw(1,0,99);
    sa(sp()+sp());
    return 7;
}
private int _7(){
    sa(sr());
    sa(gr(gr(1,0)%10,(gr(1,0)/10)+6));

    if((gr(gr(1,0)%10,(gr(1,0)/10)+6))!=0)return 8;else return 14;
}
private int _8(){
    {long v0=sp();sa((sp()>v0)?1:0);}


    if(sp()!=0)return 13;else return 9;
}
private int _9(){
    sa(gr(1,0));
    gw(1,0,gr(1,0)-1);

    if(sp()!=0)return 7;else return 10;
}
private int _10(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 11;else return 12;
}
private int _11(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 6;
}
private int _12(){
    sp();
    System.out.print(String.valueOf((long)(sp()))+" ");
    return 18;
}
private int _13(){
    sa(sp()-gr(gr(1,0)%10,(gr(1,0)/10)+6));

    gw(gr(1,0)%10,(gr(1,0)/10)+6,0);
    return 9;
}
private int _14(){
    sp();
    sp();
    return 9;
}
private int _15(){
    sa(gr(0,0));
    return 5;
}
private int _16(){
    gw(1,0,gr(1,0)+1);
    return 3;
}
private int _17(){
    gw(1,0,t0);
    return 1;
}

public void main(){
    int c=0;
    while(c<18){
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
    case 13:c=_13();break;
    case 14:c=_14();break;
    case 15:c=_15();break;
    case 16:c=_16();break;
    case 17:c=_17();break;
}
}
}
public static void main(String[]a){new Program().main();}
}

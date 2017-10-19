/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtVLsOgzAM/JU0gaWIchYEQVRF/ZAKOlTymikT/fe6MICqqFs7VJyU2HL8uMvgqL4Ps2PHjr/HD1aJ8vqugaAfuju2COjk9AhvCyeqmGATCqoYYDT5"+
                                 "Yhj2nJrRgr2rEbwjuXCV5Jzwqqmip0ZGWok3CmxtcazlVWIWTIXEmzkxX0xFBR+mtJIOfLos/hRAzpXEICG55RRFIqMWkWM0N0bvSk7IUCkdwziYgHbu2ypvVLb5lGH1"+
                                 "19os1eYjnvF4IR1ABgAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1600];for(int i=0;i<1600;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<100&&y<16)?g[(int)(y*100+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<100&&y<16)g[(int)(y*100+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(0,0,100);
    gw(6,0,1000);
    gw(8,0,0);
    gw(9,0,0);
    return 1;
}
private int _1(){
    t0=gr(6,0)-1;
    gw(6,0,gr(6,0)-1);

    if((t0)!=0)return 3;else return 2;
}
private int _2(){
    System.out.print(String.valueOf(gr(8,0))+" ");
    return 11;
}
private int _3(){
    t0=gr(6,0);
    sa(0);
    sa(gr(6,0));
    gw(3,0,gr(6,0));
    gw(1,0,t0);
    return 4;
}
private int _4(){
    sa(tm(sp(),gr(0,0)));

    sa((td(gr(1,0),gr(0,0)))+1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    t0=gr(1,0)-1;
    sa(gr(1,0)-1);
    gw(1,0,gr(1,0)-1);

    if((t0)!=0)return 10;else return 5;
}
private int _5(){
    gw(4,0,1);
    gw(5,0,0);
    sp();
    return 6;
}
private int _6(){
    gw(4,0,tm(gr(4,0)*10,gr(3,0)));
    gw(5,0,gr(5,0)+1);

    if((gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1))!=0)return 7;else return 9;
}
private int _7(){
    t0=gr(5,0)-gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1);

    if((gr(5,0)-gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1))>gr(9,0))return 8;else return 1;
}
private int _8(){
    gw(9,0,t0);
    gw(8,0,gr(3,0));
    return 1;
}
private int _9(){
    gw(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1,gr(5,0));
    return 6;
}
private int _10(){
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 4;
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

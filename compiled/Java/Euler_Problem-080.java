/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABACtkrFyhCAQhl+FQ6+RMbdy4kXCMCnyECkYTJEZWioqHz4/RM85c13UUWB32f32h8Q+85t/BzzVP54j6jP2fgTJyxEk4QgSOoLEj7WtWGXuhvTgTrtw"+
                                 "s9rMzlGzNPmq5d/ciU6vXmNrbrjtWq1HoYIbRRd15aearM6ma1BKnPE1ydJIUVotKSIJ3I2k0FZpqv180m0XlXh1baBboCFSv1XeLodxyzqhqK7Bg2Xem3FsrteFHkkH"+
                                 "iqU2CvSqaZobRbI3CgOFr9OsiixABzX9EpNbdPD3WvyNg6JhOpCMin9wiqYSq3dQy2TW4B4d6XgVo2E2I7QndLUJgpq5S8B0rSTPujUJrekg4gfvsiwEdSwiddNTZJu0"+
                                 "pRdWmkGDgPWRBoENwYiVfLKbZCkfFTQSRZoF8oz4yKi/YNTCJBA7cRFKhev+tMvVmJJ3ARu1NsTqPyEJ2aHJk52ZTqJxkrh79wi/Cy0JbRa6nZ/lWMZyN7IuNIpAYz6O"+
                                 "K+TCXDZgPxd+GB4AfwDY6hCc2gQAAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1242];for(int i=0;i<1242;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<69&&y<18)?g[(int)(y*69+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<69&&y<18)g[(int)(y*69+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
private int _0(){
    gw(9,0,0);
    gw(2,0,2);
    sa(2);
    return 1;
}
private int _1(){
    sa(100);
    sa(10000-gr(2,0));
    return 2;
}
private int _2(){
    if(sp()!=0)return 3;else return 26;
}
private int _3(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 4;else return 5;
}
private int _4(){
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()-gr(2,0));
    return 2;
}
private int _5(){
    gw(68,1,0);
    gw(68,3,0);
    gw(68,5,0);
    sp();
    sa(sr());
    sa(59);
    sa(59);
    return 6;
}
private int _6(){
    if(sp()!=0)return 34;else return 7;
}
private int _7(){
    sp();
    gw(68,1,sp());
    gw(2,0,0);
    sa(100);
    return 8;
}
private int _8(){
    gw(4,0,gr(2,0)*gr(2,0));
    t0=((gr(68,3)*gr(2,0)*20)+gr(4,0))%100;
    gw(4,0,((gr(68,3)*gr(2,0)*20)+gr(4,0))/100);
    gw(68,5,t0);
    sa(59);
    sa(59);
    return 9;
}
private int _9(){
    if(sp()!=0)return 33;else return 10;
}
private int _10(){
    sp();
    sa(0);
    sa(gr(9,5)-gr(9,1));
    return 11;
}
private int _11(){
    if(sp()!=0)return 15;else return 12;
}
private int _12(){
    sa(sp()+1L);


    if(sr()!=60)return 13;else return 14;
}
private int _13(){
    sa(sr());
    t0=gr(sr()+9,5);
    sa(sp()+9L);

    sa(1);
    {long v0=sp();t1=gr(sp(),v0);}
    sa(t0-t1);
    return 11;
}
private int _14(){
    gw(2,0,gr(2,0)+1);
    sp();
    return 8;
}
private int _15(){
    sa(sr());
    t0=gr(sr()+9,5);
    sa(sp()+9L);

    sa(1);
    {long v0=sp();t1=gr(sp(),v0);}
    t2=t0>t1?1:0;

    if((t2)!=0)return 16;else return 14;
}
private int _16(){
    gw(2,0,gr(2,0)-1);
    gw(68,5,0);
    gw(4,0,gr(2,0)*gr(2,0));
    gw(6,0,gr(68,1)-gr(4,0));
    gw(7,0,gr(68,3)*gr(2,0)*20);
    sp();
    sa(59);
    sa(59);
    return 17;
}
private int _17(){
    t0=0;
    return 18;
}
private int _18(){
    if(gr(7,0)>gr(6,0))return 32;else return 19;
}
private int _19(){
    gw(4,0,t0);
    sa(gr(6,0)-gr(7,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+8L);

    sa(5);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 20;else return 21;
}
private int _20(){
    sa(sr());
    gw(6,0,gr(sr()+9,1)-gr(4,0));
    gw(7,0,gr(sr()+9,3)*gr(2,0)*20);
    return 17;
}
private int _21(){
    gw(68,1,gr(68,5));
    sp();
    sa(59);
    sa(59);
    return 22;
}
private int _22(){
    if(sp()!=0)return 31;else return 23;
}
private int _23(){
    gw(9,3,((gr(9,3)%10)*10)+(gr(10,3)/10));
    sp();
    sa(1);
    sa(-58);
    return 24;
}
private int _24(){
    if(sp()!=0)return 30;else return 25;
}
private int _25(){
    gw(68,3,((gr(68,3)%10)*10)+gr(2,0));
    gw(9,0,gr(2,0)+gr(9,0));
    gw(2,0,0);
    sp();
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 8;else return 26;
}
private int _26(){
    sp();
    return 27;
}
private int _27(){
    sa(sr()+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-100L);


    if(sp()!=0)return 28;else return 29;
}
private int _28(){
    sa(sr());
    gw(2,0,sp());
    return 1;
}
private int _29(){
    System.out.print(String.valueOf(gr(9,0))+" ");
    sp();
    return 35;
}
private int _30(){
    sa(sr());
    sa(sr());
    t0=(gr(sr()+9,3)%10)*10;
    sa(sp()+10L);

    sa(3);
    {long v0=sp();t1=gr(sp(),v0);}
    t1/=10;
    sa(t0+t1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(3);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+1L);

    sa(sr()-59);
    return 24;
}
private int _31(){
    sa(sp()-1L);

    sa(sr());
    sa(gr(sr()+9,5));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 22;
}
private int _32(){
    gw(6,0,gr(6,0)+100);
    t0++;
    return 18;
}
private int _33(){
    sa(sp()-1L);

    sa(sr());
    sa((gr(sr()+9,3)*gr(2,0)*20)+gr(4,0));
    gw(4,0,sr()/100);
    sa(sp()%100L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(5);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 9;
}
private int _34(){
    sa(sp()-1L);

    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(3);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(5);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 6;
}

public void main(){
    int c=0;
    while(c<35){
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
    case 18:c=_18();break;
    case 19:c=_19();break;
    case 20:c=_20();break;
    case 21:c=_21();break;
    case 22:c=_22();break;
    case 23:c=_23();break;
    case 24:c=_24();break;
    case 25:c=_25();break;
    case 26:c=_26();break;
    case 27:c=_27();break;
    case 28:c=_28();break;
    case 29:c=_29();break;
    case 30:c=_30();break;
    case 31:c=_31();break;
    case 32:c=_32();break;
    case 33:c=_33();break;
    case 34:c=_34();break;
}
}
}
public static void main(String[]a){new Program().main();}
}

/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADt2k1Lw0AQBuC/st20l4S4k020zVAWL5716CGkRS0LoriI7qk/3lk/oNraFooo8j6wgelMs5uZ5taYJSotY9TF48Pt4vpJnT3fLR5VmeKru8W9ak7U"+
                                 "H5cBAAAAAAAAAAAAAAAAAAAAAAAA/AO/+V88Z3cUxNViii5GFagtPLW55UDjsvM0TiFPf/Kcn84Risp4qrqRXLjT53qqhvHbb75ZPV17GsIkU9E0HxnHLfliTH4+UEun"+
                                 "b7TNuaKgrWZLIW8o2JrCrj3eOJJSVR/LZVP2mLwtWLIsO/hRJxdTFV4rXWb9rHdVSvpykMXZesVASlK6K61h6o/G5Mg7TgeXjOMlm0bGY6wMZBoDTfJJnjOnNQlVFSpi"+
                                 "uc1ek5r12dxT7anZWN7v1YvXJ95d0rteOZmANS2FxkgwlIjzUpoQldOXupZwpRlBYier4EaaMX+/jVQP06fSQhnBWvOWm7Ye7jra3s+51ZaW919+zkqnV2nLvgfO40BT"+
                                 "9QKcPtfBiCwAAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[11400];for(int i=0;i<11400;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<200&&y<57)?g[(int)(y*200+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<200&&y<57)g[(int)(y*200+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
private int _0(){
    gw(1,0,200);
    gw(2,0,50);
    gw(4,0,10000);
    gw(3,0,2);
    return 1;
}
private int _1(){
    gw(0,1,32);
    gw(1,1,32);
    gw(8,0,1073741824);
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(4,0)?1:0);
    return 2;
}
private int _2(){
    if(sp()!=0)return 25;else return 3;
}
private int _3(){
    sp();
    return 4;
}
private int _4(){
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    return 5;
}
private int _5(){
    if((t0)!=0)return 6;else return 4;
}
private int _6(){
    if(gr(4,0)>gr(3,0))return 1;else return 7;
}
private int _7(){
    gw(3,0,0);
    gw(5,0,3);
    return 8;
}
private int _8(){
    sa(gr(5,0)+2);
    gw(5,0,gr(5,0)+2);
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=32;

    if((t0)!=0)return 9;else return 10;
}
private int _9(){
    sa(79);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 8;
}
private int _10(){
    sp();
    sa(3);
    sa((3-gr(5,0)!=0)?0:1);
    return 11;
}
private int _11(){
    if(sp()!=0)return 24;else return 12;
}
private int _12(){
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 18;else return 13;
}
private int _13(){
    sa(sr());
    t0=gr(5,0);
    gw(9,0,0);
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(sp()-v0);}

    sa(td(sp(),2));

    sa(sr());
    gw(7,0,sp());
    sa(gr(8,0));
    sa(gr(8,0)>gr(7,0)?1:0);
    return 14;
}
private int _14(){
    if(sp()!=0)return 23;else return 15;
}
private int _15(){
    sa(sr());
    return 16;
}
private int _16(){
    if(sp()!=0)return 20;else return 17;
}
private int _17(){
    sp();
    sa(sp()-(gr(9,0)*gr(9,0)));


    if(sp()!=0)return 18;else return 19;
}
private int _18(){
    sa(sp()+1L);

    sa((sr()-gr(5,0)!=0)?0:1);
    return 11;
}
private int _19(){
    sp();
    return 8;
}
private int _20(){
    if((sr()+gr(9,0))<=gr(7,0))return 22;else return 21;
}
private int _21(){
    gw(9,0,td(gr(9,0),2));
    sa(td(sp(),4));

    sa(sr());
    return 16;
}
private int _22(){
    t0=sr()+gr(9,0);
    t1=gr(7,0);
    t2=t1-t0;
    gw(7,0,t2);
    t0=(sr()*2)+gr(9,0);
    gw(9,0,t0);
    gw(9,0,td(gr(9,0),2));
    sa(td(sp(),4));
    return 15;
}
private int _23(){
    sa(td(sp(),4));

    sa(sr()>gr(7,0)?1:0);
    return 14;
}
private int _24(){
    System.out.print(String.valueOf((long)(sp()))+" ");
    return 26;
}
private int _25(){
    sa(sr());
    sa(32);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(4,0)?1:0);
    return 2;
}

public void main(){
    int c=0;
    while(c<26){
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
}
}
}
public static void main(String[]a){new Program().main();}
}

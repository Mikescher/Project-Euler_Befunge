/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABADVVsFuwyAM/RUK7ALKhrNGbVBk7UOi9NBVuXLilI8fISRNm5S1nbq074CMjeQn7Ae25CXAeyxNJAoWx9L0Xg3WpKXSxdI0IkBKKBICiW6WpvI77NIE"+
                                 "JnClFXR/oL7ELT2jgADvK24NnNQf7XENHm7/GLVlDS4Fgqo1SFAmNdF7wpwe9lTgVhm9VXWWyaH+qN3uTTeooV41CCUY5/jQq4ZgqWNREY36HG0KHDeZY1A7Z5ZlWyFE"+
                                 "wqodd1tIoo2IXFedxdlx7eDv+d6olQGueDh6pKv5y+RDxU8TTPiO1hujPEQHMlwpzJNVT+zkMFzIMMGiMi/UuUPk4lOCyNcXH8nn0hDSPV3nAuSnY/40GqLftNePOxdX"+
                                 "0BIamqVx9SQUdMDmS4JsWNmkiW7S0Dxu/XTmGtmWY+81We9Jetf3mMDwWRWk0XX6b+PKWIUsNFJXTGLZGbcRKv5ogn4mctL22sKNN9LaqdDZziC9vpBs2vfCK88d0am3"+
                                 "VBipwoOAkhWlZsVOvn89mHdg1bcXqpauuaLbkD+gJTv8AFvIfdyeDQAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[3486];for(int i=0;i<3486;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<166&&y<21)?g[(int)(y*166+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<166&&y<21)g[(int)(y*166+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    sa(31);
    return 1;
}
private int _1(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);

    sa(sr());
    return 2;
}
private int _2(){
    if(sp()!=0)return 1;else return 3;
}
private int _3(){
    gw(1,0,1);
    gw(8,0,9999);
    sp();
    sa(9);
    sa(9);
    return 4;
}
private int _4(){
    sa(gr(8,0));
    sa(9);
    return 5;
}
private int _5(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);

    sa(sr());
    return 6;
}
private int _6(){
    if(sp()!=0)return 5;else return 7;
}
private int _7(){
    sp();
    sa(sr());
    return 8;
}
private int _8(){
    sa(tm(sr(),10));
    sa(sr());

    if(sp()!=0)return 9;else return 75;
}
private int _9(){
    sa(sr());
    sa(1);
    {long v0=sp();t0=gr(sp(),v0);}
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 10;else return 75;
}
private int _10(){
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10));

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 11;else return 8;
}
private int _11(){
    sp();
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 12;
}
private int _12(){
    sa(tm(sr(),10));
    sa(sr());

    if(sp()!=0)return 13;else return 75;
}
private int _13(){
    sa(sr());
    sa(1);
    {long v0=sp();t0=gr(sp(),v0);}
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 14;else return 75;
}
private int _14(){
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10));

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 15;else return 12;
}
private int _15(){
    sp();
    sa(sp()*sp());

    sa(sr());
    return 16;
}
private int _16(){
    sa(tm(sr(),10));
    sa(sr());

    if(sp()!=0)return 17;else return 73;
}
private int _17(){
    sa(sr());
    sa(1);
    {long v0=sp();t0=gr(sp(),v0);}
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 18;else return 73;
}
private int _18(){
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10));

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 19;else return 16;
}
private int _19(){
    sp();
    sa(9);
    return 20;
}
private int _20(){
    sa(sr());
    sa(1);
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-1L);

    sa(sr());
    return 21;
}
private int _21(){
    if(sp()!=0)return 20;else return 22;
}
private int _22(){
    sp();
    sa(sp()+sp());

    t0=sp();
    sa(sp()+t0);

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()-9L);

    sa((sp()!=0)?0:1);

    if(sp()!=0)return 72;else return 23;
}
private int _23(){
    t0=gr(8,0)-1;

    if(gr(8,0)!=1001)return 71;else return 24;
}
private int _24(){
    sa(sp()-1L);


    if(sr()!=1)return 70;else return 25;
}
private int _25(){
    sp();
    gw(8,0,999);
    sa(99);
    sa(99);
    return 26;
}
private int _26(){
    sa(gr(8,0));
    sa(9);
    return 27;
}
private int _27(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);

    sa(sr());
    return 28;
}
private int _28(){
    if(sp()!=0)return 27;else return 29;
}
private int _29(){
    sp();
    sa(sr());
    return 30;
}
private int _30(){
    sa(tm(sr(),10));
    sa(sr());

    if(sp()!=0)return 31;else return 69;
}
private int _31(){
    sa(sr());
    sa(1);
    {long v0=sp();t0=gr(sp(),v0);}
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 32;else return 69;
}
private int _32(){
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10));

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 33;else return 30;
}
private int _33(){
    sp();
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 34;
}
private int _34(){
    sa(tm(sr(),10));
    sa(sr());

    if(sp()!=0)return 35;else return 69;
}
private int _35(){
    sa(sr());
    sa(1);
    {long v0=sp();t0=gr(sp(),v0);}
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 36;else return 69;
}
private int _36(){
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10));

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 37;else return 34;
}
private int _37(){
    sp();
    sa(sp()*sp());

    sa(sr());
    return 38;
}
private int _38(){
    sa(tm(sr(),10));
    sa(sr());

    if(sp()!=0)return 39;else return 67;
}
private int _39(){
    sa(sr());
    sa(1);
    {long v0=sp();t0=gr(sp(),v0);}
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 40;else return 67;
}
private int _40(){
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10));

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 41;else return 38;
}
private int _41(){
    sp();
    sa(9);
    return 42;
}
private int _42(){
    sa(sr());
    sa(1);
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-1L);

    sa(sr());
    return 43;
}
private int _43(){
    if(sp()!=0)return 42;else return 44;
}
private int _44(){
    sp();
    sa(sp()+sp());

    t0=sp();
    sa(sp()+t0);

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()-9L);

    sa((sp()!=0)?0:1);

    if(sp()!=0)return 66;else return 45;
}
private int _45(){
    sa(gr(8,0)-1);

    if(gr(8,0)!=101)return 48;else return 46;
}
private int _46(){
    sp();
    sa(sp()-1L);


    if(sr()!=10)return 47;else return 49;
}
private int _47(){
    sa(999);
    return 48;
}
private int _48(){
    gw(8,0,sp());
    sa(sr());
    return 26;
}
private int _49(){
    gw(8,0,32);
    gw(7,0,gr(8,0)-1);
    sp();
    return 50;
}
private int _50(){
    t0=gr(gr(8,0),2);

    if((gr(gr(8,0),2))==0)return 52;else return 51;
}
private int _51(){
    t0-=gr(gr(7,0),2);

    if((t0)!=0)return 52;else return 65;
}
private int _52(){
    t0=gr(7,0);

    if(gr(7,0)!=1)return 64;else return 53;
}
private int _53(){
    t0=gr(8,0);

    if(gr(8,0)!=2)return 63;else return 54;
}
private int _54(){
    sa(0);
    sa(31);
    return 55;
}
private int _55(){
    sa(sr());
    sa(2);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sr());

    if(sp()!=0)return 56;else return 62;
}
private int _56(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-1L);

    sa(sr());
    return 57;
}
private int _57(){
    if(sp()!=0)return 55;else return 58;
}
private int _58(){
    sp();
    return 59;
}
private int _59(){
    sa(sp()+sp());

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 61;else return 60;
}
private int _60(){
    sa(sp()+sp());

    System.out.print(String.valueOf((long)(sp())));
    return 76;
}
private int _61(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 59;
}
private int _62(){
    sp();
    sa(sp()-1L);

    sa(sr());
    return 57;
}
private int _63(){
    t0--;
    gw(8,0,t0);
    gw(7,0,gr(8,0)-1);
    return 50;
}
private int _64(){
    t0--;
    gw(7,0,t0);
    return 50;
}
private int _65(){
    gw(gr(7,0),2,0);
    return 52;
}
private int _66(){
    sa(gr(1,0));
    gw(1,0,gr(1,0)+1);
    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 45;
}
private int _67(){
    sp();
    return 68;
}
private int _68(){
    sp();
    sp();
    t0=0;
    return 45;
}
private int _69(){
    sp();
    return 67;
}
private int _70(){
    gw(8,0,9999);
    sa(sr());
    return 4;
}
private int _71(){
    gw(8,0,t0);
    sa(sr());
    return 4;
}
private int _72(){
    sa(gr(1,0));
    gw(1,0,gr(1,0)+1);
    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 23;
}
private int _73(){
    sp();
    return 74;
}
private int _74(){
    sp();
    sp();
    t0=0;
    return 23;
}
private int _75(){
    sp();
    return 73;
}

public void main(){
    int c=0;
    while(c<76){
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
    case 35:c=_35();break;
    case 36:c=_36();break;
    case 37:c=_37();break;
    case 38:c=_38();break;
    case 39:c=_39();break;
    case 40:c=_40();break;
    case 41:c=_41();break;
    case 42:c=_42();break;
    case 43:c=_43();break;
    case 44:c=_44();break;
    case 45:c=_45();break;
    case 46:c=_46();break;
    case 47:c=_47();break;
    case 48:c=_48();break;
    case 49:c=_49();break;
    case 50:c=_50();break;
    case 51:c=_51();break;
    case 52:c=_52();break;
    case 53:c=_53();break;
    case 54:c=_54();break;
    case 55:c=_55();break;
    case 56:c=_56();break;
    case 57:c=_57();break;
    case 58:c=_58();break;
    case 59:c=_59();break;
    case 60:c=_60();break;
    case 61:c=_61();break;
    case 62:c=_62();break;
    case 63:c=_63();break;
    case 64:c=_64();break;
    case 65:c=_65();break;
    case 66:c=_66();break;
    case 67:c=_67();break;
    case 68:c=_68();break;
    case 69:c=_69();break;
    case 70:c=_70();break;
    case 71:c=_71();break;
    case 72:c=_72();break;
    case 73:c=_73();break;
    case 74:c=_74();break;
    case 75:c=_75();break;
}
}
}
public static void main(String[]a){new Program().main();}
}

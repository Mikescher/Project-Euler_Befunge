/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABADdVMGO4yAM/RW3yV5AbDGQNkEIjfYDttfOKEr3xpUTp+6/r03SadrRaKRqTmspNQXbvPfspLy+vgJb82DwpJ1+nU7fWe/t7e1b8f1+NvETOx6P1X8X"+
                                 "vqv9R/UKDN5nJ4cxdZKXyEtDSwjP1Ityn8ZBdtmjGjdFw6rMM/VmjIu1Z+8HiXyBzn76Iq0mnkujxPbvts9oPaWibR8AzbfzZty+wNYLL4TBbC1mjTb3Pcjoe6nHvuKI"+
                                 "iOnnS2XazyQvtFbGpJ0x2XZiWl+/WNbGUzVN14c2nKdm4xXmeyDTorsPDUzCJ8Ngs0FFK5HAmFCoRNKWKSWNnj2EtQqh0F4trUcte2rmqClCdDZjpX6+3QaQorcko9GQ"+
                                 "xp00Ow9Wp1W5eKNO7WTn2NWIWCP+LNGxbaEt5j3x6lsq6B1mLywmxTq1uHcCM/86YmMykmikk+Yj6QfVq5pKomo7rWSj9tXu3bG93tOAbaBrQNReNnQwkcZepV6+iwqh"+
                                 "LSyEsbtkjKzyuvtJuPajha+NOE7R8zhqHkdM1iQh0SbpCzW+s6vmXjajQp+cuY5e5LwD5w1JLTH8cFgmuOOPhAayxR37QCMaZ0waHY0YiMj3jlAuGzUkZ6nhB3Kcld2c"+
                                 "5GUKpH8nKkZX38kbxrIiGUU0wGVFBWZckg3slXV5kCbRX3YlYjnEz2pBeKA4MzlcNXh8UxvWWqU5ar/wXej6EJeYyrFcgDjCTHK4J0kceScUFOEyBkcjhAuRtU0ris0Q"+
                                 "gTgCkVwo7meK+0QjKgTSwRTpGKT97PtS92m+KvoAU/fhk/Ixo0b8A6X0qdzQBwAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[2000];for(int i=0;i<2000;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<25)?g[(int)(y*80+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<25)g[(int)(y*80+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(2,1,67108864);
    gw(3,1,3);
    gw(1,3,0);
    gw(24,8,0);
    sa(15);
    return 1;
}
private int _1(){
    sa(sr()+8);
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(8);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);

    sa(sr());
    sa((sp()!=0)?0:1);
    return 2;
}
private int _2(){
    if(sp()!=0)return 3;else return 1;
}
private int _3(){
    sp();
    return 4;
}
private int _4(){
    sa(gr(3,1));
    gw(1,0,0);
    sa(sr());
    gw(2,0,sp());
    return 5;
}
private int _5(){
    sa(sr());
    gw(3,0,sp());
    sa(sr());
    t0=gr(2,0);
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(td(sp(),v0));}

    t1=sp();
    sa(sp()+t1);

    sa(td(sp(),2));


    if(sr()!=gr(3,0))return 54;else return 6;
}
private int _6(){
    sp();
    sa(gr(3,0));
    gw(4,1,gr(3,0));
    sa(sr());
    sa(sp()*sp());

    t0=sp();
    t0-=gr(3,1);

    if((t0)!=0)return 7;else return 53;
}
private int _7(){
    gw(24,5,0);
    gw(24,4,0);
    gw(24,1,0);
    gw(24,0,0);
    sa(15);
    return 8;
}
private int _8(){
    sa(sr()+8);
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(5);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()+8);
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(4);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()+8);
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()+8);
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(0);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);

    sa(sr());
    sa((sp()!=0)?0:1);
    return 9;
}
private int _9(){
    if(sp()!=0)return 10;else return 8;
}
private int _10(){
    gw(24,1,1);
    gw(24,4,1);
    gw(1,2,0);
    gw(2,2,1);
    gw(3,2,td(gr(4,1)+gr(1,2),gr(2,2)));
    sp();
    return 11;
}
private int _11(){
    sa(15);
    sa(15);
    sa(gr(24,0)+(gr(24,1)*gr(3,2))+gr(1,3));
    gw(1,3,td(gr(24,0)+(gr(24,1)*gr(3,2))+gr(1,3),gr(2,1)));
    return 12;
}
private int _12(){
    sa(tm(sp(),gr(2,1)));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)return 52;else return 13;
}
private int _13(){
    sp();
    sa(15);
    sa(15);
    sa(gr(24,4)+(gr(24,5)*gr(3,2))+gr(1,3));
    gw(1,3,td(gr(24,4)+(gr(24,5)*gr(3,2))+gr(1,3),gr(2,1)));
    return 14;
}
private int _14(){
    sa(tm(sp(),gr(2,1)));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(6);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)return 15;else return 16;
}
private int _15(){
    sa(sr());
    sa(sr());
    sa(sr()+9);
    sa(4);
    {long v0=sp();t0=gr(sp(),v0);}
    sa(sp()+9L);

    sa(5);
    {long v0=sp();t1=gr(sp(),v0);}
    t1*=gr(3,2);
    sa(t0+t1);
    sa(sp()+gr(1,3));

    t0=td(sr(),gr(2,1));
    gw(1,3,t0);
    return 14;
}
private int _16(){
    gw(1,4,1);
    gw(24,9,0);
    sp();
    sa(14);
    return 17;
}
private int _17(){
    sa(sr()+9);
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(9);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 18;
}
private int _18(){
    if(sp()!=0)return 17;else return 19;
}
private int _19(){
    gw(2,4,15);
    gw(3,4,gr(2,4)+9);
    sp();
    return 20;
}
private int _20(){
    sa(15);
    sa((gr(24,6)*gr(gr(2,4)+9,6)*gr(3,1))+gr(1,4)+gr(gr(3,4),9));
    gw(1,4,td((gr(24,6)*gr(gr(2,4)+9,6)*gr(3,1))+gr(1,4)+gr(gr(3,4),9),gr(2,1)));
    return 21;
}
private int _21(){
    sa(tm(sp(),gr(2,1)));

    gw(gr(3,4),9,sp());
    sa(sp()-1L);


    if(gr(3,4)-9==0)return 22;else return 51;
}
private int _22(){
    sp();
    t0=gr(2,4)-1;

    if((gr(2,4))==0)return 23;else return 50;
}
private int _23(){
    gw(1,4,0);
    gw(24,7,0);
    sa(14);
    return 24;
}
private int _24(){
    sa(sr()+9);
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(7);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 25;
}
private int _25(){
    if(sp()!=0)return 24;else return 26;
}
private int _26(){
    gw(2,4,15);
    gw(3,4,gr(2,4)+9);
    sp();
    return 27;
}
private int _27(){
    sa(15);
    sa((gr(24,2)*gr(gr(2,4)+9,2))+gr(1,4)+gr(gr(3,4),7));
    gw(1,4,td((gr(24,2)*gr(gr(2,4)+9,2))+gr(1,4)+gr(gr(3,4),7),gr(2,1)));
    return 28;
}
private int _28(){
    sa(tm(sp(),gr(2,1)));

    gw(gr(3,4),7,sp());
    sa(sp()-1L);


    if(gr(3,4)-9==0)return 29;else return 49;
}
private int _29(){
    sp();
    t0=gr(2,4)-1;

    if((gr(2,4))==0)return 30;else return 48;
}
private int _30(){
    sa(15);
    sa(gr(24,7)-gr(24,9));
    return 31;
}
private int _31(){
    if(sp()!=0)return 44;else return 32;
}
private int _32(){
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)return 43;else return 33;
}
private int _33(){
    sp();
    sa(0);
    sa(gr(9,2)-gr(9,8));
    sa(gr(9,2)-gr(9,8));
    return 34;
}
private int _34(){
    if(sp()!=0)return 39;else return 35;
}
private int _35(){
    sp();
    sa(sp()+1L);


    if(sr()-17==0)return 36;else return 38;
}
private int _36(){
    sp();
    t0=gr(3,1)+1;
    gw(3,1,gr(3,1)+1);
    t0-=1000;

    if((t0)!=0)return 4;else return 37;
}
private int _37()throws java.io.IOException{
    System.out.print(String.valueOf(gr(1,1)));
    return 56;
}
private int _38(){
    sa(sr());
    sa(sr()+9);
    sa(2);
    {long v0=sp();t0=gr(sp(),v0);}
    sa(sp()+9L);

    sa(8);
    {long v0=sp();t1=gr(sp(),v0);}
    sa(t0-t1);
    sa(sr());
    return 34;
}
private int _39(){
    sa((sp()>0)?1:0);


    if(sp()!=0)return 40;else return 36;
}
private int _40(){
    gw(1,1,gr(3,1));
    gw(24,8,gr(24,2));
    sp();
    sa(14);
    return 41;
}
private int _41(){
    sa(sr());
    sa(sr()+9);
    sa(2);
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(8);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((sp()!=0)?0:1);
    return 42;
}
private int _42(){
    if(sp()!=0)return 36;else return 41;
}
private int _43(){
    sa(sr());
    sa(sr()+9);
    sa(7);
    {long v0=sp();t0=gr(sp(),v0);}
    sa(sp()+9L);

    sa(9);
    {long v0=sp();t1=gr(sp(),v0);}
    sa(t0-t1);
    return 31;
}
private int _44(){
    gw(1,2,(gr(3,2)*gr(2,2))-gr(1,2));
    gw(2,2,td(gr(3,1)-(gr(1,2)*gr(1,2)),gr(2,2)));
    sp();
    sa(15);
    return 45;
}
private int _45(){
    sa(sr());
    sa(sr()+9);
    sa(1);
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(0);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr()+9);
    sa(2);
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr()+9);
    sa(5);
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(4);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr()+9);
    sa(6);
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(5);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((sp()!=0)?0:1);
    return 46;
}
private int _46(){
    if(sp()!=0)return 47;else return 45;
}
private int _47(){
    gw(3,2,td(gr(4,1)+gr(1,2),gr(2,2)));
    sp();
    return 11;
}
private int _48(){
    gw(2,4,t0);
    gw(3,4,gr(2,4)+9);
    return 27;
}
private int _49(){
    sa(sr());
    t0=(sr()+gr(2,4))-6;
    gw(3,4,t0);
    sa(sp()+9L);

    sa(2);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(gr(2,4)+9,2));

    sa(sp()+gr(1,4));

    sa(sp()+gr(gr(3,4),7));

    t0=td(sr(),gr(2,1));
    gw(1,4,t0);
    return 28;
}
private int _50(){
    gw(2,4,t0);
    gw(3,4,gr(2,4)+9);
    return 20;
}
private int _51(){
    sa(sr());
    t0=(sr()+gr(2,4))-6;
    gw(3,4,t0);
    sa(sp()+9L);

    sa(6);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(gr(2,4)+9,6)*gr(3,1));

    sa(sp()+gr(1,4));

    sa(sp()+gr(gr(3,4),9));

    t0=td(sr(),gr(2,1));
    gw(1,4,t0);
    return 21;
}
private int _52(){
    sa(sr());
    sa(sr());
    sa(sr()+9);
    sa(0);
    {long v0=sp();t0=gr(sp(),v0);}
    sa(sp()+9L);

    sa(1);
    {long v0=sp();t1=gr(sp(),v0);}
    t1*=gr(3,2);
    sa(t0+t1);
    sa(sp()+gr(1,3));

    t0=td(sr(),gr(2,1));
    gw(1,3,t0);
    return 12;
}
private int _53(){
    gw(3,1,gr(3,1)+1);
    sa(gr(3,1));
    gw(1,0,0);
    sa(sr());
    gw(2,0,sp());
    return 5;
}
private int _54(){
    if(sr()!=gr(1,0))return 55;else return 6;
}
private int _55(){
    gw(1,0,gr(3,0));
    return 5;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<56){
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
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}

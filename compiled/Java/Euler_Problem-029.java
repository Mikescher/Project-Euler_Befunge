/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADt1NFOwjAUBuBXGd24WTM9HWzAQhp8AN8At5sl9bJXvTI8u6erEEKGOsVo6v8nhNK1Z+cbFJf801AsmehOYwnccMMNN9xxBG644YYb7jgCN9xwww13"+
                                 "HIEbbrjhhjuOwA033HDDHUfghhtuuOGOI3DDDTfccMcRuOGGG2644wjcyPXoRDw9Hh4OPs8zIYfkMs8VWdEcpJB5VUke96LMlSzJut9u+SaZrtj+QBcfZWqXoUexFJfN"+
                                 "7u4MyarKjvNjhbfjW/1vJCQbbWd00lJ1z/ezVF+We5d07RnrYpa67vN1RiqUZBin12Qb2q/JWH6polFF2nYZD/yb6Puwgq/tS0qM5rXKOq14t7JLspoqsvyh5mHNc2ZJ"+
                                 "Jq/IyIZPydzP2Hqo68sNZV2XkVrx8k2+8hukIjP3I9mshlLF0MJbexuyC77/gsyGjGlefOf+/HHJ4RhmTodr560Pg50+gdxx1nXttKcU0nZtOmsKdfZtTK/zreOis6C0"+
                                 "2Wnm6tovEW+2/S9ky3/OYZAkr+fUiHQoOQAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[14632];for(int i=0;i<14632;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<248&&y<59)?g[(int)(y*248+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<248&&y<59)g[(int)(y*248+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(1,0,357913941);
    gw(10,0,9802);
    gw(2,0,201);
    sa(gr(2,0));
    gw(8,0,52);
    return 1;
}
private int _1(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(gr(8,0));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    t0=gr(8,0)-1;

    if(gr(8,0)!=2)return 31;else return 2;
}
private int _2(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 3;else return 4;
}
private int _3(){
    gw(8,0,52);
    return 1;
}
private int _4(){
    gw(8,0,100);
    sp();
    sa(100);
    sa(gr(8,0));
    sa(100);
    return 5;
}
private int _5(){
    sa(gr(2,0));
    gw(gr(2,0),1,0);
    return 6;
}
private int _6(){
    sa(sp()-1L);

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 8;else return 7;
}
private int _7(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 6;
}
private int _8(){
    gw(gr(2,0),1,1);
    sp();
    gw(4,0,sp());
    return 9;
}
private int _9(){
    gw(5,0,0);
    gw(6,0,gr(2,0));
    return 10;
}
private int _10(){
    t0=(gr(gr(6,0),1)*gr(4,0))+gr(5,0);
    gw(gr(6,0),1,tm((gr(gr(6,0),1)*gr(4,0))+gr(5,0),10));
    t1=gr(6,0)-1;

    if(gr(6,0)!=1)return 30;else return 11;
}
private int _11(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 9;else return 12;
}
private int _12(){
    gw(7,0,1);
    sp();
    sa(tm(gr(gr(7,0),1),gr(1,0)));
    return 13;
}
private int _13(){
    t0=gr(7,0)+1;
    gw(7,0,gr(7,0)+1);
    t0-=gr(2,0);
    t0--;

    if((t0)!=0)return 29;else return 14;
}
private int _14(){
    sa(gr(2,0));
    gw(9,0,52);
    return 15;
}
private int _15(){
    gw(3,0,sp());
    sa(sr());
    t0=gr(gr(3,0),gr(9,0));

    if((gr(gr(3,0),gr(9,0)))!=0)return 16;else return 28;
}
private int _16(){
    sa(sp()-t0);

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)return 22;else return 17;
}
private int _17(){
    sa(gr(3,0));
    t0=gr(9,0)-1;

    if(gr(9,0)!=2)return 21;else return 18;
}
private int _18(){
    sa(sp()-1L);


    if(sr()!=1)return 20;else return 19;
}
private int _19(){
    return 32;
}
private int _20(){
    gw(9,0,52);
    return 15;
}
private int _21(){
    gw(9,0,t0);
    return 15;
}
private int _22(){
    gw(10,0,gr(10,0)-1);
    sp();
    return 23;
}
private int _23(){
    t0=gr(8,0)-1;

    if(gr(8,0)!=2)return 27;else return 24;
}
private int _24(){
    sa(sp()-1L);


    if(sr()!=1)return 25;else return 26;
}
private int _25(){
    gw(8,0,100);
    sa(sr());
    sa(gr(8,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 5;
}
private int _26(){
    System.out.print(String.valueOf(gr(10,0))+" ");
    sp();
    return 32;
}
private int _27(){
    gw(8,0,t0);
    sa(sr());
    sa(gr(8,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 5;
}
private int _28(){
    gw(gr(3,0),gr(9,0),sp());
    sp();
    return 23;
}
private int _29(){
    sa(sp()*9L);

    sa(sp()+gr(gr(7,0),1));

    sa(tm(sp(),gr(1,0)));
    return 13;
}
private int _30(){
    gw(6,0,t1);
    t0/=10;
    gw(5,0,t0);
    return 10;
}
private int _31(){
    gw(8,0,t0);
    return 1;
}

public void main(){
    int c=0;
    while(c<32){
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
}
}
}
public static void main(String[]a){new Program().main();}
}

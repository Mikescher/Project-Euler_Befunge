/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABAC9jz0KAjEQha+SnZhmh5hMhogECbZeYrcR0qZK6dkddxVEEGOzrxjmD977mt9AbQMPynCFTDYNus3Jc/XEFW4XwMA1By5yNoRr4wp4sJ7LSFwwxYjm"+
                                 "cFRNdWla6k5/rOdJD5VDslQ4VCaHMVYnZjIimWcznvpMVuUFgAUm84uA3whQKRkTWXnpjf9N5/2D4NfXX/HVHUV2dgFeAgAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[606];for(int i=0;i<606;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<101&&y<6)?g[(int)(y*101+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<101&&y<6)g[(int)(y*101+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    sa(99);
    return 1;
}
private int _1(){
    sa(sr());
    gw(0,3,sp());
    gw(1,3,0);
    gw(2,3,199);
    return 2;
}
private int _2(){
    t0=((gr((tm(gr(2,3),100))+1,td(gr(2,3),100))-48)*gr(0,3))+gr(1,3);
    gw((tm(gr(2,3),100))+1,td(gr(2,3),100),(tm(((gr((tm(gr(2,3),100))+1,td(gr(2,3),100))-48)*gr(0,3))+gr(1,3),10))+48);
    t0/=10;
    gw(1,3,t0);
    t0=gr(2,3)-1;
    gw(2,3,gr(2,3)-1);
    t0=(t0!=0)?0:1;
    return 3;
}
private int _3(){
    if((t0)!=0)return 4;else return 2;
}
private int _4(){
    sa(sp()-1L);

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 5;else return 1;
}
private int _5(){
    gw(3,3,199);
    sp();
    t0=gr((tm(gr(3,3),100))+1,td(gr(3,3),100))-48;
    return 6;
}
private int _6(){
    t1=gr(3,3);
    gw(3,3,gr(3,3)-1);
    t1=(t1!=0)?0:1;

    if((t1)!=0)return 7;else return 8;
}
private int _7(){
    System.out.print(String.valueOf(t0)+" ");
    return 9;
}
private int _8(){
    t0+=gr((tm(gr(3,3),100))+1,td(gr(3,3),100))-48;
    return 6;
}

public void main(){
    int c=0;
    while(c<9){
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
}
}
}
public static void main(String[]a){new Program().main();}
}

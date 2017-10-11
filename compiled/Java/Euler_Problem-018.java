/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABAC9VMtqw0AM/JUh7SnGRVp5X6GYfkhJevPVp3x/R17ogxjaErvCOCvh7OxoRguM0Y4QmUUm7QN/VeZRZbLjKbDUTQc59DF2x1ftPgsdv1iyWf194p+Y"+
                                 "9to/XC9cnD62Yn7FbeS4UsR5rfjLeL7J13BrRBpuqmtfbncSD80YMkq4e/MRj385rRZYRMlQ+boJxQ59E20RuwnbFqGjfJ63NfqTvI0P50s/fhOdEjd5m9w0y9xy0enp"+
                                 "JQhkcL5knVa1vkvsNbkb3wpRBHODicFutd4nSoEE5IxsEFI2pPwfuLV6e9nqwAMkaEIW1Ptt9lMM6k9IiAnFMAiKOLTZ/rgFOTgQrWVcZGdd2YG6I26kowg9eLdDxGCo"+
                                 "ihhQM6JCd7MZW6rqZKlvcxdvksyhpu7F13Efm5FdXgjagkKCrJB1LIiCkL3bFGLz8MFJ7meyK9XbzjkyWYgnpOpXGc1mujGuI1LNslDjCNdljorjVvMm+EmWOy1s6vB3"+
                                 "lpN0goAHAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1920];for(int i=0;i<1920;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<120&&y<16)?g[(int)(y*120+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<120&&y<16)g[(int)(y*120+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(0,0,15);
    gw(2,0,gr(0,0)-1);
    gw(1,0,0);
    return 1;
}
private int _1(){
    gw(gr(1,0),gr(2,0)+1,((gr(gr(1,0)*3,gr(2,0)+1)-48)*10)+(gr((gr(1,0)*3)+1,gr(2,0)+1)-48));
    t0=gr(1,0)+1;
    gw(1,0,gr(1,0)+1);
    t0-=gr(2,0);
    t0--;
    return 2;
}
private int _2(){
    if((t0)!=0)return 1;else return 3;
}
private int _3(){
    t0=gr(2,0);
    gw(2,0,gr(2,0)-1);
    gw(1,0,0);

    if((t0)!=0)return 1;else return 4;
}
private int _4(){
    t0=gr(0,0)-2;
    gw(1,0,gr(0,0)-2);
    gw(2,0,t0);
    return 5;
}
private int _5(){
    sa(gr(gr(1,0),gr(2,0)+1));
    sa(gr(gr(1,0),gr(2,0)+2));
    t0=gr(gr(1,0),gr(2,0)+2)-gr(gr(1,0)+1,gr(2,0)+2);

    if((gr(gr(1,0),gr(2,0)+2)-gr(gr(1,0)+1,gr(2,0)+2))>0)return 6;else return 9;
}
private int _6(){
    sa(sp()+sp());

    t0=sp();
    gw(gr(1,0),gr(2,0)+1,t0);
    t0=gr(1,0);
    gw(1,0,gr(1,0)-1);

    if((t0)!=0)return 5;else return 7;
}
private int _7(){
    t0=gr(2,0);
    t1=gr(2,0)-1;
    gw(2,0,gr(2,0)-1);
    gw(1,0,t1);

    if((t0)!=0)return 5;else return 8;
}
private int _8(){
    System.out.print(String.valueOf(gr(0,1))+" ");
    return 10;
}
private int _9(){
    sa(sp()-t0);
    return 6;
}

public void main(){
    int c=0;
    while(c<10){
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
}
}
}
public static void main(String[]a){new Program().main();}
}

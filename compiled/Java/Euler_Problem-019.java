/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABACtkcFqxCAQhl8lNU0pimXmNyREgvRBQnopzNWTpzx8xyULuwS2bNoRRceZz3/GEihAx2VpzlsJ/C+c4Q+5t5ZgU4wkhozvR+sWyjGWU6gtes68ODv2"+
                                 "XnHCzfw8pDSvJ7KOlkDIzDqBbPBmLLuATBPyU9UVkGMBZUxOML04ryfuRnXNqd2DqG1K3e/K01FNSSpE2KmgAOm7u9vtGsVNSoAsUmO93w6cX2pWtPk2nebRWsW0V64+"+
                                 "q9zITpsxDO4huXS2V4ogaIHrF68q0Du25h0XZ0aoHQlK5EdfddOFNVWKuibIx+fuuwuefwDyEoFQYAMAAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[864];for(int i=0;i<864;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<72&&y<12)?g[(int)(y*72+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<72&&y<12)g[(int)(y*72+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(12,0,gr(12,0)-20);
    gw(12,1,gr(12,1)-20);
    sa(11);
    return 1;
}
private int _1(){
    sa(sr());
    sa(sr());
    sa(0);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48L);

    sa(sp()+28L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(0);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr());
    sa(1);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48L);

    sa(sp()+28L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);

    sa(sr());
    return 2;
}
private int _2(){
    if(sp()!=0)return 1;else return 3;
}
private int _3(){
    gw(0,2,2);
    gw(1,2,1);
    gw(2,2,1);
    gw(3,2,1901);
    gw(9,2,0);
    gw(9,2,(((tm(gr(0,2),7))+(gr(1,2)-1)!=0)?0:1)+gr(9,2));
    gw(0,2,gr(0,2)+1);
    gw(1,2,gr(1,2)+1);
    sp();
    return 4;
}
private int _4(){
    if(tm(gr(3,2),4)!=0)return 5;else return 12;
}
private int _5(){
    sa(gr(gr(2,2),0)-(gr(1,2)-1));
    return 6;
}
private int _6(){
    if(sp()!=0)return 9;else return 7;
}
private int _7(){
    gw(1,2,1);
    t0=gr(2,2);
    gw(2,2,gr(2,2)+1);
    t0-=12;

    if((t0)!=0)return 9;else return 8;
}
private int _8(){
    gw(2,2,1);
    gw(3,2,gr(3,2)+1);
    return 9;
}
private int _9(){
    if(gr(3,2)!=2001)return 10;else return 11;
}
private int _10(){
    gw(9,2,(((tm(gr(0,2),7))+(gr(1,2)-1)!=0)?0:1)+gr(9,2));
    gw(0,2,gr(0,2)+1);
    gw(1,2,gr(1,2)+1);
    return 4;
}
private int _11()throws java.io.IOException{
    System.out.print(String.valueOf(gr(9,2)));
    return 15;
}
private int _12(){
    if(tm(gr(3,2),100)!=0)return 13;else return 14;
}
private int _13(){
    sa(gr(gr(2,2),1)-(gr(1,2)-1));
    return 6;
}
private int _14(){
    if(tm(gr(3,2),400)!=0)return 5;else return 13;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<15){
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
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}

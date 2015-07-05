/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADlmM1uIzcQhF+lIWcvGjjmP4eCoAR5DsPOba466bQPv1+1tJtdIM5KCJhLiLFEzlBgTXV1NemLfd8u9kg7PjT7oXbalV16OezjcwhnO1kIYTuY37RP"+
                                    "u992y+tt8BIXO5vp8XWuPb29X5YP2zzId7T/G6ywWkiWko1uebVYiZOVoM9Ov1jgs1tfrSaLySr3u42oH34WrKe/af8eVhm6xhCU2G2NFkHQrQVbu+5wf6xWsjXmrAJa"+
                                    "m7Uk3BNhgQNYOVrPVqv1YbFYAmi2HoWpdavZ1tUyFGZNjtkyyOpMWISmw0e1lMUEJEXQJHGTGK7iJkTLSR2A5q6gA4s4ToSFqqAq+pI1ipsGN8Qr2vDla9Gc4oJLq7Vm"+
                                    "OYuwdWoQoaR0kQFPKExhquKjFEkeBEQQvYNvBV+wXCW4q/YnwgIQikZhYqIolBAWIaYpMW/aGuKMWEMVCZF9Zp8Ki1VBAA3NnaK5CyRXG9EcxfJQJzhE9AQyZS4vMFdb"+
                                    "RQlYV/kTS5KPhBKgw92B8HENIpiVocrHIuUBtKepsKJ0ozQc7p+4ZZOwIAyRSUlFN1uUzmS5RSmi/lSDgIzozoS2yDjJ3PMRuydSwTNOxpGUrYI4NBmzGFPZYjHUQwTx"+
                                    "KoKVHRa5eY0sUUvOlqAX9UXtsLWqEsx0+eaGGVRYwIR7IR2KoIAWXfhncZsl3ADF28AnlFNrYhwKEwbRXPXDbUwWv7r8kztn8zrdVaSDSx4uy1SDUOlNyv/1quiqTCSy"+
                                    "EMawutMyTH5RMRF76rI60nZmEN3BoWp1EM1Ni+SX3XudQf50oAc/UzHIquLVNxRz2SrOByHDvlNVBlCtUTcBBR+2Li91pWcvjkDHRPJUtuTvQ2tQmwHB7iXlm22yPAHl"+
                                    "6ZpuJYgE7EVvwvw4G5Z4qiJDJZmNQ9BOprttUme061ql+tU3GoCunqfk48wgRhVdVeIo1V/zv7nqtbHJwoTFsztVZrh9kLwS3EyDuJxDeI77w55KQzvHZYm1hnPw78i4"+
                                    "1ueosY+G9+GTqSGG44NHjBO/vussetLBr5b9p7yPyyudl7Jsu7B7rmm//+tZ+uHZ8vXB4+fE0y+nKx3/DOvzPdjVnNXDxsF1KS9w+7rs/tg9ytbb+9vTn1uIh+MH2L4e"+
                                    "1E+89O1MfUpJH2EbyyFsOZzjVojYjRgCK74aX2ED0dLCBnlVM7eFpxrTY8LppzMupnU4nrPi0+X921Gdg3oM26/2+/evwh9vcy99H7Yjem3LFsoW2jlUenkLdVs0FsUM"+
                                    "jm/i5UpWmPivjB/az9na7/dv/xGYb+3uBY8f8/QFUdxTbEkSAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<151&&y<31)?g[y*151+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<151&&y<31)g[y*151+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(0L,0L,675L);
    _1:
        gw((tm(gr(0L,0L),26L))+63L,(td(gr(0L,0L),26L))+1L,0L);
        sa(gr(0L,0L));
        gw(0L,0L,gr(0L,0L)-1L);
        if(sp()!=0)goto _1;else goto _3;
    _3:
        gw(1L,0L,0L);
        gw(9L,0L,0L);
        gw(9L,1L,-1L);
        gw(10L,0L,1L);
        gw(10L,1L,-1L);
        gw(11L,0L,1L);
        gw(11L,1L,0L);
        gw(0L,0L,399L);
    _4:
        gw((tm(gr(0L,0L),20L))+66L,(td(gr(0L,0L),20L))+4L,((gr(((tm(gr(0L,0L),20L))*3L)+1L,(td(gr(0L,0L),20L))+4L)-48L)*10L)+(gr(((tm(gr(0L,0L),20L))*3L)+2L,(td(gr(0L,0L),20L))+4L)-48L));
        sa(gr(0L,0L));
        gw(0L,0L,gr(0L,0L)-1L);
        if(sp()!=0)goto _4;else goto _6;
    _6:
        gw(0L,0L,399L);
    _7:
        gw(2L,0L,2L);
    _8:
        sa(gr(2L,0L)+9L);
        gw(3L,0L,gr(gr(2L,0L)+9L,0L));
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        gw(4L,0L,sp());
        sa(gr(0L,0L));
        gw(5L,0L,tm(gr(0L,0L),20L));
        sa(td(sp(),20L));
        gw(6L,0L,sp());
        sa(gr(gr(5L,0L)+66L,gr(6L,0L)+4L));
        gw(5L,0L,gr(5L,0L)+gr(3L,0L));
        gw(6L,0L,gr(6L,0L)+gr(4L,0L));
        sa(gr(gr(5L,0L)+66L,gr(6L,0L)+4L));
        gw(5L,0L,gr(5L,0L)+gr(3L,0L));
        gw(6L,0L,gr(6L,0L)+gr(4L,0L));
        sa(gr(gr(5L,0L)+66L,gr(6L,0L)+4L));
        gw(5L,0L,gr(5L,0L)+gr(3L,0L));
        gw(6L,0L,gr(6L,0L)+gr(4L,0L));
        sa(gr(gr(5L,0L)+66L,gr(6L,0L)+4L));
        gw(5L,0L,gr(5L,0L)+gr(3L,0L));
        gw(6L,0L,gr(6L,0L)+gr(4L,0L));
        sa(sp()*sp());
        sa(sp()*sp());
        sa(sp()*sp());
        if(sr()>gr(1L,0L))goto _13;else goto _9;
    _9:
        sp();
    _10:
        sa(gr(2L,0L));
        gw(2L,0L,gr(2L,0L)-1L);
        if(sp()!=0)goto _8;else goto _11;
    _11:
        sa(gr(0L,0L));
        gw(0L,0L,gr(0L,0L)-1L);
        if(sp()!=0)goto _7;else goto _12;
    _12:
        System.Console.Out.Write((long)(gr(1L,0L)));
        return;
    _13:
        gw(1L,0L,sp());
        goto _10;
}}
#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("Ah+LCAAAAAAABADt3N1Lk3EYxvHf6IEk6jGJRtLLBlYkJLPC5cjcZhi9sbIZi9FwEQ6D5kFWY5os1pspEkEr6syoDgIbUimijIWkEiwRlCcnix10VNtBg2m6YjX/hzGQ"
  + "7+foPrq5ji9ubk1PkciRROJLn2xybjFN25b0c5L58bUGl2+f60CNsdvmbLOMJHf82tPdojSfGlNHal9VpUYy5ZGGgErctCn1M0+HjP93xCf2CwAAAAAAsOpUz91eo8oN"
  + "2qxy9Mw5AAAAAACw2l0slqVcF3DrT9NWc6HDAAAAAACAvLt7uHrjyoVAyueWCh0GAAAAAADk3eaFuGmlC5jMfihpLHQaAAAAAACQd9Ggb1bya+Vw8IVn3cdd0wZDdtvV"
  + "72Z/1N0RCIQ69AM95XXPT8Yzzq8xjfXKwfUFemwAAAAA5FlaEr8Xl3/ceKsuGXtTcb00c0iEdRfutahnrdbOkLy495On/75mpwgXLR9zvHQNP+ibf2LXlaVju1PzXnuT"
  + "xbHJG+odtXjbk55HZSmvz3i2s6b/RKM9kRaVr3+2PYvELn1T3h3/25ytlQdOGxYMg0cSn93KhssO/3D9djE+MxWd1AWLlyYSoalka5c+0Dta9V4Vf9i+1pI5X6q906r6"
  + "B8tNsPstXAAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<2000 and y<12010):
        return g[y*2000 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<2000 and y<12010):
        g[y*2000 + x]=v;
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
def _0():
    gw(1,1,12000)
    gw(5,1,0)
    gw(2,1,2000)
    gw(6,1,1)
    gw(7,1,1)
    sa(1)
    sa(1)
    sa((1)if(1<gr(6,1))else(0))
    return 1
def _1():
    return (5)if(sp()!=0)else(2)
def _2():
    sp();

    return (4)if((sr()-gr(1,1))!=0)else(3)
def _3():
    print(gr(5,1),end=" ",flush=True)
    sp();
    return 10
def _4():
    sa(sp()+1)

    gw(6,1,(sr()+1)/2)
    sa(sr());
    gw(7,1,sp())
    sa((sr()/3)+1)
    sa((1)if(sr()<gr(6,1))else(0))
    return 1
def _5():
    return (6)if((gr(tm(sr(),gr(2,1)),gr(7,1)+3))!=0)else(9)
def _6():
    gw(5,1,gr(5,1)+1)
    sa(sr());
    gw(8,1,sp())
    gw(9,1,gr(7,1))
    return 7
def _7():
    return (9)if((((1)if(gr(8,1)>gr(1,1))else(0))+((1)if(gr(9,1)>gr(1,1))else(0)))!=0)else(8)
def _8():
    gw(tm(gr(8,1),gr(2,1)),gr(9,1)+3,0)
    gw(8,1,sr()+gr(8,1))
    gw(9,1,gr(7,1)+gr(9,1))
    return 7
def _9():
    sa(sp()+1)

    sa((1)if(sr()<gr(6,1))else(0))
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9]
c=0
while c<10:
    c=m[c]()

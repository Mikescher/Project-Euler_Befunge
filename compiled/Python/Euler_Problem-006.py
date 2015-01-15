# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABADtUbsOgzAM/JXwWhpRnAEGy4r6IVFBaqWsTJn4+NpFPAW0Hdh6g2X5nPPFjp+xgRYAWmvAI4DXnJsck1CnwJSNH7EwaDReHJaoM8ehqHTbcI/qEWx6vfXpXc3QgqGN8sRq48EoGirwjnajd41wTHcROup4QG6QJ1Ca1iGJ0Ouq0Fi6jIPUFZK44D9qkgbOMRdLJJkHcmKdFtK22TDIqzh0NL1YtIV87Wg2y/I1hnxYXzLimyXNX678jljaBLn1/Mgf9ryj8zNWOtumBaRolzvPz1/nJJ0XFH7TnYAEAAA="
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<72 and y<16):
        return g[y*72 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<72 and y<16):
        g[y*72 + x]=v;
def rd():
    return bool(random.getrandbits(1))
def td(a,b):
    return bool(random.getrandbits(1))
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
    return (25)if(sp()!=0)else(9)
def _1():
    return (11)if(sp()!=0)else(12)
def _2():
    return (15)if(sp()!=0)else(14)
def _3():
    return (17)if(sp()!=0)else(21)
def _4():
    return (23)if(sp()!=0)else(22)
def _5():
    return (19)if(sp()!=0)else(20)
def _6():
    return (24)if((0)if((gr(tm(gr(1,0),10),(td(gr(1,0),10))+(6)))!=0)else(1))else(18)
def _7():
    gw(1,0,100)
    gw(0,0,0)
    return 8
def _8():
    sa(gr(1,0))
    gw(0,0,(gr(1,0))+(gr(0,0)))
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 0
def _9():
    gw(1,0,0)
    sp()
    return 10
def _10():
    sa(99)
    sa(gr(1,0))
    gw(tm(gr(1,0),10),(td(gr(1,0),10))+(6),((gr(1,0))+(1))*((gr(1,0))+(1)))
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 1
def _11():
    gw(1,0,(gr(1,0))+(1))
    return 10
def _12():
    sa(gr(0,0))
    gw(1,0,gr(0,0))
    return 13
def _13():
    sa((gr(1,0))-(1))
    gw(1,0,(gr(1,0))-(1))
    sa((0)if(sp()!=0)else(1))
    return 2
def _14():
    sa(gr(0,0))
    return 13
def _15():
    gw(1,0,99)
    return 16
def _16():
    sa(sp()+sp());
    return 17
def _17():
    sa(sr())
    sa(gr(tm(gr(1,0),10),(td(gr(1,0),10))+(6)))
    return 6
def _18():
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 5
def _19():
    sa(gr(tm(gr(1,0),10),(td(gr(1,0),10))+(6)))
    gw(tm(gr(1,0),10),(td(gr(1,0),10))+(6),0)
    v0=sp()
    sa(sp()-v0)
    return 20
def _20():
    sa(gr(1,0))
    gw(1,0,(gr(1,0))-(1))
    return 3
def _21():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 4
def _22():
    gw(1,0,99)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 16
def _23():
    sp()
    print(sp(),end="",flush=True)
    return 26
def _24():
    sp()
    sp()
    return 20
def _25():
    gw(1,0,sp())
    return 8
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25]
c=7
while c<26:
    c=m[c]()
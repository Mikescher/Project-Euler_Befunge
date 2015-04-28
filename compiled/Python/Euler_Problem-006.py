# compiled with BefunCompile v1.0.4 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("AR+LCAAAAAAABADtUbsOgzAM/JXwWhpRnAEGy4r6IVFBaqWsTJn4+NpFPAW0Hdh6g2X5nPPFjp+xgRYAWmvAI4DXnJsck1CnwJSNH7EwaDReHJaoM8ehqHTbcI/qEWx6"
  + "vfXpXc3QgqGN8sRq48EoGirwjnajd41wTHcROup4QG6QJ1Ca1iGJ0Ouq0Fi6jIPUFZK44D9qkgbOMRdLJJkHcmKdFtK22TDIqzh0NL1YtIV87Wg2y/I1hnxYXzLimyXN"
  + "X678jljaBLn1/Mgf9ryj8zNWOtumBaRolzvPz1/nJJ0XFH7TnYAEAAA=")
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
    gw(1,0,100)
    gw(0,0,0)
    return 1
def _1():
    sa(gr(1,0))
    gw(0,0,(gr(1,0))+(gr(0,0)))
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return (2)if(sp()!=0)else(3)
def _2():
    gw(1,0,sp())
    return 1
def _3():
    gw(1,0,0)
    sp()
    return 4
def _4():
    sa(99)
    sa(gr(1,0))
    gw(tm(gr(1,0),10),(td(gr(1,0),10))+(6),((gr(1,0))+(1))*((gr(1,0))+(1)))
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return (18)if(sp()!=0)else(5)
def _5():
    sa(gr(0,0))
    gw(1,0,gr(0,0))
    return 6
def _6():
    sa((gr(1,0))-(1))
    gw(1,0,(gr(1,0))-(1))
    sa((0)if(sp()!=0)else(1))
    return (7)if(sp()!=0)else(17)
def _7():
    gw(1,0,99)
    return 8
def _8():
    sa(sp()+sp());
    return 9
def _9():
    sa(sr())
    sa(gr(tm(gr(1,0),10),(td(gr(1,0),10))+(6)))
    return (16)if((0)if((gr(tm(gr(1,0),10),(td(gr(1,0),10))+(6)))!=0)else(1))else(10)
def _10():
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return (15)if(sp()!=0)else(11)
def _11():
    sa(gr(1,0))
    gw(1,0,(gr(1,0))-(1))
    return (9)if(sp()!=0)else(12)
def _12():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return (13)if(sp()!=0)else(14)
def _13():
    sp()
    print(sp(),end="",flush=True)
    return 19
def _14():
    gw(1,0,99)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 8
def _15():
    sa(gr(tm(gr(1,0),10),(td(gr(1,0),10))+(6)))
    gw(tm(gr(1,0),10),(td(gr(1,0),10))+(6),0)
    v0=sp()
    sa(sp()-v0)
    return 11
def _16():
    sp()
    sp()
    return 11
def _17():
    sa(gr(0,0))
    return 6
def _18():
    gw(1,0,(gr(1,0))+(1))
    return 4
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18]
c=0
while c<19:
    c=m[c]()
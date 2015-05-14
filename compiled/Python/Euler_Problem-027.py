# compiled with BefunCompile v1.0.5 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("Ah+LCAAAAAAABACT7+ZgAAEWhrc3HLsvO4gwPNg/ybdMn3Pr5JTbtzaw6N+zrdLIDTzdsEZC7O1J+fchYbp5u7vWeJTv57eacOaM9tJ+c/2badaPC7+9evb499nb/jdP"
  + "n78+e3bOlt11xXt/Trjqy8bQH8rIQBPwwSP1A/+Xn7trospKJW7tOXl6HaezJb/z5bZEo5k2+qc/GfEsXNv+duLbyHutZStuK3NXzPpnIb2O726MbncpTy7P58OfbUJr"
  + "/1nlO/uwasfpXDLIW60Y+/1lcOlnAfHXt1uPlpXu2x0dHrsq9ffr5FWRi9+c/v9HdE7H04CtjyVeHXWV2nX03RZv1szK83xfu2z5r4t66tQ9ztv01XXb349vLFoiw68a"
  + "nqlbFjTf6renlcrrRKmk4jWn7eXqz+u96E5PXTNbxG/TvBV2MW0Wq1Z7VrHNaVvIf1enN3bmpBSxpJmblqzaVTV31/J/fv6hOuGZvtevFf7NLr+6/K/v1aUrNP/80jFN"
  + "/33/iv/+r5mXmWtvRXLNStv/ftf7J09LZH7LB++14mefJl79+ejCzujw+q+LfLZaRcYzHtq6S3BDNSMDABHvrYXvAQAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<600 and y<162):
        return g[y*600 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<600 and y<162):
        g[y*600 + x]=v;
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
    gw(1,0,600)
    gw(2,0,150)
    gw(9,0,90000)
    gw(3,0,2)
    gw(4,0,1000)
    gw(3,1,0)
    return 1
def _1():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88)
    sa(gr(3,0)+gr(3,0))
    sa((1)if((gr(9,0))>(gr(3,0)+gr(3,0)))else(0))
    return 2
def _2():
    return (22)if(sp()!=0)else(3)
def _3():
    sp()
    return 4
def _4():
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(32)
    v0=sp()
    sa(sp()-v0)
    return 5
def _5():
    return (6)if(sp()!=0)else(4)
def _6():
    sa((1)if((gr(9,0))>(gr(3,0)))else(0))
    return (1)if(sp()!=0)else(7)
def _7():
    gw(0,3,32)
    gw(1,3,32)
    gw(5,0,(0-gr(4,0))+1)
    gw(6,0,2)
    return 8
def _8():
    gw(7,0,0)
    sa(0+(gr(5,0)*gr(7,0))+gr(6,0))
    sa((1)if((0+(gr(5,0)*gr(7,0))+gr(6,0))>(1))else(0))
    return 9
def _9():
    return (10)if(sp()!=0)else(21)
def _10():
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(32)
    v0=sp()
    sa(sp()-v0)
    return (20)if(sp()!=0)else(11)
def _11():
    sa(gr(7,0))
    sa((1)if((gr(7,0))>(gr(3,1)))else(0))
    return (19)if(sp()!=0)else(12)
def _12():
    sp()
    return 13
def _13():
    sa(gr(5,0)+2)
    gw(5,0,gr(5,0)+2)
    sa(gr(4,0))
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    sa((0)if(sp()!=0)else(1))
    return (8)if(sp()!=0)else(14)
def _14():
    gw(5,0,(0-gr(4,0))+1)
    return 15
def _15():
    sa(gr(6,0)+1)
    gw(6,0,gr(6,0)+1)
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(32)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 16
def _16():
    return (15)if(sp()!=0)else(17)
def _17():
    sa((0)if(((1)if((gr(6,0))>(gr(4,0)))else(0))!=0)else(1))
    return (8)if(sp()!=0)else(18)
def _18():
    print(gr(1,1)*gr(2,1),end="",flush=True)
    return 23
def _19():
    gw(3,1,sp())
    gw(1,1,gr(5,0))
    gw(2,1,gr(6,0))
    return 13
def _20():
    sa(gr(7,0)+1)
    gw(7,0,gr(7,0)+1)
    sa(sr())
    sa(sp()*sp());
    sa((gr(5,0)*gr(7,0))+gr(6,0))
    sa(sp()+sp());
    sa(sr())
    sa(1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 9
def _21():
    sp()
    return 11
def _22():
    sa(sr())
    sa(32)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(gr(3,0))
    sa(sp()+sp());
    sa(sr())
    sa(gr(9,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22]
c=0
while c<23:
    c=m[c]()
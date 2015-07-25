#!/usr/bin/env python3
# compiled with BefunCompile v1.0.7 (c) 2015
import gzip, base64
_g = ("AR+LCAAAAAAABADtk01ug0AMha9CIWxs0dgj/mYUod6gF0CQ3SzrFascvm4SlAAJUdMsKoSl+dHT6I3ne9AF/7yi19bq90e/Nd9l+635LttvzXfZfmu+y/Zb812234ur"
  + "KgoowWDlqHbhZxgz1rpsDcpIKSdKYeCkqU838j0gu4QFoUy3erZGjnVxNTlBBGPLiQppdqXtxn1uAlY5l+Ns4LhmOcjk5vl6fHp883xVOUFBkjOUOhuwOqvCR4Vvdlfp"
  + "IH3PzdY6CL9CGwilJGxYmHVYMPn97ho91DbR3jMHLvFkILsArAJikh9WUHHinDMkgwzJG0Q/TPqkGWDyiC7LMHZR046f0syTabvICfEWs0wjN57sdeTa5u7yaiEbo7WY"
  + "6ymhst+XQkW/LzbXT59l+EQpQ3NiaEYMqwf82GcpTAj26hzDB/zGBPX/8DxleHbUj+RMiq1wT5BL4Z4gDwneq4rZG/b7t6hrU/KM+iE+S1Xr4M6bhC+3/+4XG7a30abe"
  + "P543GNU3DXw8oeAQAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<80 and y<54):
        return g[y*80 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<80 and y<54):
        g[y*80 + x]=v;
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
    gw(79,6,0)
    gw(79,12,0)
    gw(79,18,0)
    gw(79,24,0)
    gw(79,30,0)
    gw(79,36,0)
    sa(393)
    return 1
def _1():
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),79))+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),79))
    sa(sp()+2);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),79))+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),79))
    sa(sp()+8);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),79))+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),79))
    sa(sp()+14);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),79))+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),79))
    sa(sp()+20);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),79))+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),79))
    sa(sp()+26);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),79))+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),79))
    sa(sp()+32);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1);
    return 2
def _2():
    return (1)if((sr()+1)!=0)else(3)
def _3():
    gw(79,6,1)
    gw(79,12,1)
    gw(79,30,1)
    gw(7,0,0)
    gw(8,0,6)
    gw(9,0,12)
    gw(7,1,0)
    gw(8,1,6)
    gw(9,1,12)
    gw(1,1,1)
    gw(2,1,1)
    gw(4,0,0)
    gw(1,0,0)
    gw(2,0,394)
    sp()
    sa(999)
    return 4
def _4():
    sa(394)
    sa(gr(79,4+gr(7,0)+2)+(gr(79,4+gr(8,0)+2)*2)+gr(1,0))
    sa(tm(gr(79,4+gr(7,0)+2)+(gr(79,4+gr(8,0)+2)*2)+gr(1,0),10))
    sa(tm(gr(79,4+gr(7,0)+2)+(gr(79,4+gr(8,0)+2)*2)+gr(1,0),10))
    return 5
def _5():
    return (6)if(sp()!=0)else(7)
def _6():
    global t0
    t0=395-gr(2,0)
    return (20)if((395-gr(2,0))>gr(1,1))else(7)
def _7():
    gw((tm(gr(2,0),79))+1,(td(gr(2,0),79))+gr(9,0)+2,sp())
    sa(td(sp(),10))
    gw(1,0,sp())
    sa(sr())
    return (19)if(sp()!=0)else(8)
def _8():
    gw(7,0,tm(gr(7,0)+6,18))
    gw(8,0,tm(gr(8,0)+6,18))
    gw(9,0,tm(gr(9,0)+6,18))
    gw(1,0,0)
    gw(2,0,394)
    sp()
    sa(394)
    sa(gr(79,4+gr(7,1)+20)+(gr(79,4+gr(8,1)+20)*2)+gr(1,0))
    sa(tm(gr(79,4+gr(7,1)+20)+(gr(79,4+gr(8,1)+20)*2)+gr(1,0),10))
    sa(tm(gr(79,4+gr(7,1)+20)+(gr(79,4+gr(8,1)+20)*2)+gr(1,0),10))
    return 9
def _9():
    return (10)if(sp()!=0)else(11)
def _10():
    global t0
    t0=395-gr(2,0)
    return (18)if((395-gr(2,0))>gr(2,1))else(11)
def _11():
    gw((tm(gr(2,0),79))+1,(td(gr(2,0),79))+gr(9,1)+20,sp())
    sa(td(sp(),10))
    gw(1,0,sp())
    sa(sr())
    return (17)if(sp()!=0)else(12)
def _12():
    gw(7,1,tm(gr(7,1)+6,18))
    gw(8,1,tm(gr(8,1)+6,18))
    gw(9,1,tm(gr(9,1)+6,18))
    sp()
    return (13)if(gr(1,1)<=gr(2,1))else(16)
def _13():
    sa(sp()-1);
    sa(sr())
    return (14)if(sp()!=0)else(15)
def _14():
    gw(1,0,0)
    gw(2,0,394)
    return 4
def _15():
    print(gr(4,0),end="",flush=True)
    sp()
    return 21
def _16():
    gw(4,0,gr(4,0)+1)
    return 13
def _17():
    global t0
    global t1
    global t1
    global t1
    sa(sp()-1);
    sa(sr())
    sa(sr())
    sa(sr())
    gw(2,0,sp())
    sa((tm(sr(),79))+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),79))
    sa(sp()+gr(7,1)+20);
    v0=sp()
    t0=gr(sp(),v0)
    sa((tm(sr(),79))+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),79))
    sa(sp()+gr(8,1)+20);
    v0=sp()
    t1=gr(sp(),v0)
    t1=t1*2
    t1=t1+gr(1,0)
    sa(t0+t1)
    sa(tm(sr(),10))
    sa(sr())
    return 9
def _18():
    global t0
    gw(2,1,t0)
    return 11
def _19():
    global t0
    global t1
    global t1
    global t1
    sa(sp()-1);
    sa(sr())
    sa(sr())
    sa(sr())
    gw(2,0,sp())
    sa((tm(sr(),79))+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),79))
    sa(sp()+gr(7,0)+2);
    v0=sp()
    t0=gr(sp(),v0)
    sa((tm(sr(),79))+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),79))
    sa(sp()+gr(8,0)+2);
    v0=sp()
    t1=gr(sp(),v0)
    t1=t1*2
    t1=t1+gr(1,0)
    sa(t0+t1)
    sa(tm(sr(),10))
    sa(sr())
    return 5
def _20():
    global t0
    gw(1,1,t0)
    return 7
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20]
c=0
while c<21:
    c=m[c]()
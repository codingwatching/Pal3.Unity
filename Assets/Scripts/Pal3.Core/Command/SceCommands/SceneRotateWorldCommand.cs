// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2025, Jiaqi (0x7c13) Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.Core.Command.SceCommands
{
    #if PAL3
    [SceCommand(117, "旋转整个场景，" +
                    "参数：原GameBox坐标系下的X轴旋转角度, Y轴旋转角度, Z轴旋转角度")]
    public sealed class SceneRotateWorldCommand : ICommand
    {
        public SceneRotateWorldCommand(int xDegrees, int yDegrees, int zDegrees)
        {
            XDegrees = xDegrees;
            YDegrees = yDegrees;
            ZDegrees = zDegrees;
        }

        public int XDegrees { get; }
        public int YDegrees { get; }
        public int ZDegrees { get; }
    }
    #elif PAL3A
    [SceCommand(117, "旋转整个场景，" +
                     "参数：原GameBox坐标系下的X轴旋转角度, Y轴旋转角度, Z轴旋转角度，动画时间，旋转正反向")]
    public sealed class SceneRotateWorldCommand : ICommand
    {
        public SceneRotateWorldCommand(int xDegrees, int yDegrees, int zDegrees, int duration, int inverse)
        {
            XDegrees = xDegrees;
            YDegrees = yDegrees;
            ZDegrees = zDegrees;
            Duration = duration;
            Inverse = inverse;
        }

        public int XDegrees { get; }
        public int YDegrees { get; }
        public int ZDegrees { get; }
        public int Duration { get; }
        public int Inverse { get; }
    }
    #endif
}
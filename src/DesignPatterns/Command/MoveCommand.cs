using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// 移動コマンドクラス
    /// </summary>
    internal class MoveCommand : ICommand
    {
        private readonly Player _player;
        private readonly Vector3 _direction;

        public MoveCommand(Player player, Vector3 direction)
        {
            this._player = player;
            this._direction = direction;
        }

        /// <summary>
        /// 移動する
        /// </summary>
        public void Execute()
        {
            _player.Move(this._direction);
        }

        /// <summary>
        /// 移動コマンドのやり直し
        /// </summary>
        public void Undo()
        {
            _player.Move(-this._direction);
        }
    }
}

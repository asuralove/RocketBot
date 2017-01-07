﻿#region using directives

using System.Threading.Tasks;
using NecroBot2.WebSocketHandler.GetCommands.Tasks;
using PoGo.NecroBot.Logic.State;
using SuperSocket.WebSocket;

#endregion

namespace NecroBot2.WebSocketHandler.GetCommands
{
    public class GetPokemonListHandler : IWebSocketRequestHandler
    {
        public GetPokemonListHandler()
        {
            Command = "GetPokemonList";
        }

        public string Command { get; }

        public async Task Handle(ISession session, WebSocketSession webSocketSession, dynamic message)
        {
            await GetPokemonListTask.Execute(session, webSocketSession, (string) message.RequestID);
        }
    }
}
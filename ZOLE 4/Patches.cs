﻿using System;
using System.Collections.Generic;

using System.Text;
using GBHL;

namespace ZOLE_4
{
	public class Patches
	{
		public static void removeForestRand(GBFile gb)
		{
			gb.WriteByte(0x5F54, 0x18);
		}

		public static void setMakuGate(GBFile gb, byte b)
		{

		}

		public static void sixteenOverworld(GBFile gb)
		{
			gb.WriteByte(0x41A5, 0xF);
			gb.WriteByte(0x41AE, 0xF0);
		}

		public static void removeStartLock(GBFile gb, Program.GameTypes game)
		{
			//ASM script
			if(game == Program.GameTypes.Ages)
				gb.WriteBytes(0x1FF00, new byte[] { 0xEA, 0x11, 0x11, 0x3E, 0xDD, 0xEA, 0xD1, 0xC6, 0xC9 });
			else
				gb.WriteBytes(0x1FF00, new byte[] { 0xEA, 0x11, 0x11, 0x3E, 0xDD, 0xEA, 0xCB, 0xC6, 0xC9 });
			//Calling of ASM script
			if(game == Program.GameTypes.Ages)
				gb.WriteBytes(0x1C10B, new byte[] { 0xCD, 0x00, 0x7F });
			else
				gb.WriteBytes(0x1C103, new byte[] { 0xCD, 0x00, 0x7F });
		}

		public static void InstantAwake(GBFile gb)
		{

		}

		public static void crystalSwitches(GBFile gb)
		{
			gb.WriteByte(0x3657, 0xFF);
		}

		public static void ExtraInteractionBank(GBFile gb, Program.GameTypes game)
		{
			if (game == Program.GameTypes.Ages)
			{
				// Call ASM script
				gb.WriteBytes(0x54328, new byte[] { 0xC3, 0xFC, 0x7B });
				// ASM script
				gb.WriteBytes(0x57bfc, new byte[] {
				0x56, 0x5F, 0xCB, 0x7A, 0xC8, 0xCB, 0xBA, 0x62, 0x6B, 0x0E, 0x08, 0x11,
				0x00, 0xC3, 0x06, 0xC6, 0xCD, 0x83, 0x1A, 0x0D, 0x20, 0xF8, 0x11, 0x00,
				0xC3, 0xC9});
			}
		}
	}
}

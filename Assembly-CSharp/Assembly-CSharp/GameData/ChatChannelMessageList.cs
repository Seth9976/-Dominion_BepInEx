using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x02000132 RID: 306
	public sealed class ChatChannelMessageList : ValueType
	{
		// Token: 0x060021D1 RID: 8657 RVA: 0x0001518E File Offset: 0x0001338E
		// Note: this type is marked as 'beforefieldinit'.
		static ChatChannelMessageList()
		{
			Il2CppClassPointerStore<ChatChannelMessageList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "ChatChannelMessageList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatChannelMessageList>.NativeClassPtr);
			ChatChannelMessageList.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatChannelMessageList>.NativeClassPtr, "entries");
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x000151C7 File Offset: 0x000133C7
		public ChatChannelMessageList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x000151D0 File Offset: 0x000133D0
		public ChatChannelMessageList()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatChannelMessageList>.NativeClassPtr))
		{
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x000801AC File Offset: 0x0007E3AC
		// (set) Token: 0x060021D5 RID: 8661 RVA: 0x000151E2 File Offset: 0x000133E2
		public unsafe Il2CppReferenceArray<ChatChannelMessageEntry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatChannelMessageList.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ChatChannelMessageEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatChannelMessageList.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeFieldInfoPtr_entries;
	}
}

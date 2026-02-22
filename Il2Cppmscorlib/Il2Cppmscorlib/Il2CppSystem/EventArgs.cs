using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000A0 RID: 160
	[Serializable]
	public class EventArgs : Object
	{
		// Token: 0x06000B5D RID: 2909 RVA: 0x00055A10 File Offset: 0x00053C10
		// Note: this type is marked as 'beforefieldinit'.
		static EventArgs()
		{
			Il2CppClassPointerStore<EventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "EventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventArgs>.NativeClassPtr);
			EventArgs.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventArgs>.NativeClassPtr, "Empty");
			EventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventArgs>.NativeClassPtr, 100665225);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00055A68 File Offset: 0x00053C68
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00004E2E File Offset: 0x0000302E
		public EventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00055AA4 File Offset: 0x00053CA4
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x00004E37 File Offset: 0x00003037
		public unsafe static EventArgs Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventArgs.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventArgs.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000089 RID: 137
	[Serializable]
	public sealed class ConsoleCancelEventArgs : EventArgs
	{
		// Token: 0x0600086D RID: 2157 RVA: 0x00047E04 File Offset: 0x00046004
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleCancelEventArgs()
		{
			Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleCancelEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr);
			ConsoleCancelEventArgs.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, "_type");
			ConsoleCancelEventArgs.NativeFieldInfoPtr__cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, "_cancel");
			ConsoleCancelEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_ConsoleSpecialKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, 100664641);
			ConsoleCancelEventArgs.NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, 100664642);
			ConsoleCancelEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, 100664643);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00047E98 File Offset: 0x00046098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278040, XrefRangeEnd = 278044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleCancelEventArgs(ConsoleSpecialKey type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_ConsoleSpecialKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00047EE0 File Offset: 0x000460E0
		public unsafe bool Cancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventArgs.NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00047F1C File Offset: 0x0004611C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278044, XrefRangeEnd = 278047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleCancelEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00004872 File Offset: 0x00002A72
		public ConsoleCancelEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x00047F58 File Offset: 0x00046158
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x0000487B File Offset: 0x00002A7B
		public unsafe ConsoleSpecialKey _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleCancelEventArgs.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleCancelEventArgs.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00047F80 File Offset: 0x00046180
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x00004896 File Offset: 0x00002A96
		public unsafe bool _cancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleCancelEventArgs.NativeFieldInfoPtr__cancel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleCancelEventArgs.NativeFieldInfoPtr__cancel)) = value;
			}
		}

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeFieldInfoPtr__cancel;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConsoleSpecialKey_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}

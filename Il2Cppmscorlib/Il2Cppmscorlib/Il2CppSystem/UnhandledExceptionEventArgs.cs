using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000FE RID: 254
	[Serializable]
	public class UnhandledExceptionEventArgs : EventArgs
	{
		// Token: 0x060012AC RID: 4780 RVA: 0x000790C4 File Offset: 0x000772C4
		// Note: this type is marked as 'beforefieldinit'.
		static UnhandledExceptionEventArgs()
		{
			Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnhandledExceptionEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr);
			UnhandledExceptionEventArgs.NativeFieldInfoPtr__Exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, "_Exception");
			UnhandledExceptionEventArgs.NativeFieldInfoPtr__IsTerminating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, "_IsTerminating");
			UnhandledExceptionEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, 100666566);
			UnhandledExceptionEventArgs.NativeMethodInfoPtr_get_ExceptionObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, 100666567);
			UnhandledExceptionEventArgs.NativeMethodInfoPtr_get_IsTerminating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, 100666568);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00079158 File Offset: 0x00077358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303185, XrefRangeEnd = 303189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnhandledExceptionEventArgs(Object exception, bool isTerminating)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTerminating;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x000791B4 File Offset: 0x000773B4
		public unsafe Object ExceptionObject
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventArgs.NativeMethodInfoPtr_get_ExceptionObject_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x000791F4 File Offset: 0x000773F4
		public unsafe bool IsTerminating
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventArgs.NativeMethodInfoPtr_get_IsTerminating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00006671 File Offset: 0x00004871
		public UnhandledExceptionEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00079230 File Offset: 0x00077430
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x0000667A File Offset: 0x0000487A
		public unsafe Object _Exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnhandledExceptionEventArgs.NativeFieldInfoPtr__Exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnhandledExceptionEventArgs.NativeFieldInfoPtr__Exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00079260 File Offset: 0x00077460
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x00006699 File Offset: 0x00004899
		public unsafe bool _IsTerminating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnhandledExceptionEventArgs.NativeFieldInfoPtr__IsTerminating);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnhandledExceptionEventArgs.NativeFieldInfoPtr__IsTerminating)) = value;
			}
		}

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeFieldInfoPtr__Exception;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeFieldInfoPtr__IsTerminating;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionObject_Public_get_Object_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTerminating_Public_get_Boolean_0;
	}
}

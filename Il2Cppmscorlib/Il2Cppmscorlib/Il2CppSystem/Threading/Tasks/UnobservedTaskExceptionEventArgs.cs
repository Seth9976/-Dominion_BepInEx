using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B5 RID: 693
	public class UnobservedTaskExceptionEventArgs : EventArgs
	{
		// Token: 0x06002EB8 RID: 11960 RVA: 0x000EC088 File Offset: 0x000EA288
		// Note: this type is marked as 'beforefieldinit'.
		static UnobservedTaskExceptionEventArgs()
		{
			Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "UnobservedTaskExceptionEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr);
			UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr, "m_exception");
			UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_observed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr, "m_observed");
			UnobservedTaskExceptionEventArgs.NativeMethodInfoPtr__ctor_Public_Void_AggregateException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr, 100670703);
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x000EC0F4 File Offset: 0x000EA2F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337162, RefRangeEnd = 337163, XrefRangeStart = 337158, XrefRangeEnd = 337162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnobservedTaskExceptionEventArgs(AggregateException exception)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnobservedTaskExceptionEventArgs.NativeMethodInfoPtr__ctor_Public_Void_AggregateException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x000104F6 File Offset: 0x0000E6F6
		public UnobservedTaskExceptionEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x000EC140 File Offset: 0x000EA340
		// (set) Token: 0x06002EBC RID: 11964 RVA: 0x000104FF File Offset: 0x0000E6FF
		public unsafe AggregateException m_exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x000EC170 File Offset: 0x000EA370
		// (set) Token: 0x06002EBE RID: 11966 RVA: 0x0001051E File Offset: 0x0000E71E
		public unsafe bool m_observed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_observed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_observed)) = value;
			}
		}

		// Token: 0x04002874 RID: 10356
		private static readonly IntPtr NativeFieldInfoPtr_m_exception;

		// Token: 0x04002875 RID: 10357
		private static readonly IntPtr NativeFieldInfoPtr_m_observed;

		// Token: 0x04002876 RID: 10358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AggregateException_0;
	}
}

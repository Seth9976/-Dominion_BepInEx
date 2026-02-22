using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C7 RID: 455
	public class ExceptionHandlingClause : Object
	{
		// Token: 0x06001D3D RID: 7485 RVA: 0x000A5428 File Offset: 0x000A3628
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionHandlingClause()
		{
			Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ExceptionHandlingClause");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr);
			ExceptionHandlingClause.NativeFieldInfoPtr_catch_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "catch_type");
			ExceptionHandlingClause.NativeFieldInfoPtr_filter_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "filter_offset");
			ExceptionHandlingClause.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "flags");
			ExceptionHandlingClause.NativeFieldInfoPtr_try_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "try_offset");
			ExceptionHandlingClause.NativeFieldInfoPtr_try_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "try_length");
			ExceptionHandlingClause.NativeFieldInfoPtr_handler_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "handler_offset");
			ExceptionHandlingClause.NativeFieldInfoPtr_handler_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "handler_length");
			ExceptionHandlingClause.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, 100668162);
			ExceptionHandlingClause.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, 100668163);
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x000A550C File Offset: 0x000A370C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionHandlingClause()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHandlingClause.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x000A5548 File Offset: 0x000A3748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318205, XrefRangeEnd = 318240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExceptionHandlingClause.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0000A0F6 File Offset: 0x000082F6
		public ExceptionHandlingClause(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x000A558C File Offset: 0x000A378C
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x0000A0FF File Offset: 0x000082FF
		public unsafe Type catch_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_catch_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_catch_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x000A55BC File Offset: 0x000A37BC
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x0000A11E File Offset: 0x0000831E
		public unsafe int filter_offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_filter_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_filter_offset)) = value;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x000A55E4 File Offset: 0x000A37E4
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x0000A139 File Offset: 0x00008339
		public unsafe ExceptionHandlingClauseOptions flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x000A560C File Offset: 0x000A380C
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x0000A154 File Offset: 0x00008354
		public unsafe int try_offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_try_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_try_offset)) = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x000A5634 File Offset: 0x000A3834
		// (set) Token: 0x06001D4A RID: 7498 RVA: 0x0000A16F File Offset: 0x0000836F
		public unsafe int try_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_try_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_try_length)) = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x000A565C File Offset: 0x000A385C
		// (set) Token: 0x06001D4C RID: 7500 RVA: 0x0000A18A File Offset: 0x0000838A
		public unsafe int handler_offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_handler_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_handler_offset)) = value;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x000A5684 File Offset: 0x000A3884
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x0000A1A5 File Offset: 0x000083A5
		public unsafe int handler_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_handler_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_handler_length)) = value;
			}
		}

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeFieldInfoPtr_catch_type;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeFieldInfoPtr_filter_offset;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeFieldInfoPtr_try_offset;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeFieldInfoPtr_try_length;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeFieldInfoPtr_handler_offset;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeFieldInfoPtr_handler_length;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

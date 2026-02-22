using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001CA RID: 458
	public class MethodBody : Object
	{
		// Token: 0x06001D72 RID: 7538 RVA: 0x000A612C File Offset: 0x000A432C
		// Note: this type is marked as 'beforefieldinit'.
		static MethodBody()
		{
			Il2CppClassPointerStore<MethodBody>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MethodBody");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodBody>.NativeClassPtr);
			MethodBody.NativeFieldInfoPtr_clauses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, "clauses");
			MethodBody.NativeFieldInfoPtr_locals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, "locals");
			MethodBody.NativeFieldInfoPtr_il = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, "il");
			MethodBody.NativeFieldInfoPtr_init_locals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, "init_locals");
			MethodBody.NativeFieldInfoPtr_sig_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, "sig_token");
			MethodBody.NativeFieldInfoPtr_max_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, "max_stack");
			MethodBody.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, 100668189);
			MethodBody.NativeMethodInfoPtr_GetILAsByteArray_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, 100668190);
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x000A61FC File Offset: 0x000A43FC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodBody()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodBody>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBody.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x000A6238 File Offset: 0x000A4438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetILAsByteArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBody.NativeMethodInfoPtr_GetILAsByteArray_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x0000A227 File Offset: 0x00008427
		public MethodBody(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x000A6284 File Offset: 0x000A4484
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x0000A230 File Offset: 0x00008430
		public unsafe Il2CppReferenceArray<ExceptionHandlingClause> clauses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_clauses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExceptionHandlingClause>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_clauses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x000A62B4 File Offset: 0x000A44B4
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x0000A24F File Offset: 0x0000844F
		public unsafe Il2CppReferenceArray<LocalVariableInfo> locals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_locals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalVariableInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_locals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x000A62E4 File Offset: 0x000A44E4
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0000A26E File Offset: 0x0000846E
		public unsafe Il2CppStructArray<byte> il
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_il);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_il), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x000A6314 File Offset: 0x000A4514
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x0000A28D File Offset: 0x0000848D
		public unsafe bool init_locals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_init_locals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_init_locals)) = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x000A633C File Offset: 0x000A453C
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0000A2A8 File Offset: 0x000084A8
		public unsafe int sig_token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_sig_token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_sig_token)) = value;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x000A6364 File Offset: 0x000A4564
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0000A2C3 File Offset: 0x000084C3
		public unsafe int max_stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_max_stack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_max_stack)) = value;
			}
		}

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeFieldInfoPtr_clauses;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeFieldInfoPtr_locals;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeFieldInfoPtr_il;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeFieldInfoPtr_init_locals;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeFieldInfoPtr_sig_token;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeFieldInfoPtr_max_stack;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeMethodInfoPtr_GetILAsByteArray_Public_Virtual_New_Il2CppStructArray_1_Byte_0;
	}
}

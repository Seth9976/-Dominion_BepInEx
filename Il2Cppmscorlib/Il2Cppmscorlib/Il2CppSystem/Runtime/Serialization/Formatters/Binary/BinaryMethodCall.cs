using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000359 RID: 857
	public sealed class BinaryMethodCall : Object
	{
		// Token: 0x060036A6 RID: 13990 RVA: 0x00109148 File Offset: 0x00107348
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryMethodCall()
		{
			Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryMethodCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr);
			BinaryMethodCall.NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "methodName");
			BinaryMethodCall.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "typeName");
			BinaryMethodCall.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "args");
			BinaryMethodCall.NativeFieldInfoPtr_callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "callContext");
			BinaryMethodCall.NativeFieldInfoPtr_argTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "argTypes");
			BinaryMethodCall.NativeFieldInfoPtr_bArgsPrimitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "bArgsPrimitive");
			BinaryMethodCall.NativeFieldInfoPtr_messageEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "messageEnum");
			BinaryMethodCall.NativeMethodInfoPtr_Write_Internal_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, 100671695);
			BinaryMethodCall.NativeMethodInfoPtr_Dump_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, 100671696);
			BinaryMethodCall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, 100671697);
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x00109240 File Offset: 0x00107440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344995, RefRangeEnd = 344996, XrefRangeStart = 344983, XrefRangeEnd = 344995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodCall.NativeMethodInfoPtr_Write_Internal_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x00109284 File Offset: 0x00107484
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodCall.NativeMethodInfoPtr_Dump_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x001092B8 File Offset: 0x001074B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344997, RefRangeEnd = 344998, XrefRangeStart = 344996, XrefRangeEnd = 344997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryMethodCall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodCall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x00013AB7 File Offset: 0x00011CB7
		public BinaryMethodCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x060036AB RID: 13995 RVA: 0x001092F4 File Offset: 0x001074F4
		// (set) Token: 0x060036AC RID: 13996 RVA: 0x00013AC0 File Offset: 0x00011CC0
		public unsafe string methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x060036AD RID: 13997 RVA: 0x0010931C File Offset: 0x0010751C
		// (set) Token: 0x060036AE RID: 13998 RVA: 0x00013ADF File Offset: 0x00011CDF
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x00109344 File Offset: 0x00107544
		// (set) Token: 0x060036B0 RID: 14000 RVA: 0x00013AFE File Offset: 0x00011CFE
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x00109374 File Offset: 0x00107574
		// (set) Token: 0x060036B2 RID: 14002 RVA: 0x00013B1D File Offset: 0x00011D1D
		public unsafe Object callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x001093A4 File Offset: 0x001075A4
		// (set) Token: 0x060036B4 RID: 14004 RVA: 0x00013B3C File Offset: 0x00011D3C
		public unsafe Il2CppReferenceArray<Type> argTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_argTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_argTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x001093D4 File Offset: 0x001075D4
		// (set) Token: 0x060036B6 RID: 14006 RVA: 0x00013B5B File Offset: 0x00011D5B
		public unsafe bool bArgsPrimitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_bArgsPrimitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_bArgsPrimitive)) = value;
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060036B7 RID: 14007 RVA: 0x001093FC File Offset: 0x001075FC
		// (set) Token: 0x060036B8 RID: 14008 RVA: 0x00013B76 File Offset: 0x00011D76
		public unsafe MessageEnum messageEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_messageEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_messageEnum)) = value;
			}
		}

		// Token: 0x04002E05 RID: 11781
		private static readonly IntPtr NativeFieldInfoPtr_methodName;

		// Token: 0x04002E06 RID: 11782
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04002E07 RID: 11783
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04002E08 RID: 11784
		private static readonly IntPtr NativeFieldInfoPtr_callContext;

		// Token: 0x04002E09 RID: 11785
		private static readonly IntPtr NativeFieldInfoPtr_argTypes;

		// Token: 0x04002E0A RID: 11786
		private static readonly IntPtr NativeFieldInfoPtr_bArgsPrimitive;

		// Token: 0x04002E0B RID: 11787
		private static readonly IntPtr NativeFieldInfoPtr_messageEnum;

		// Token: 0x04002E0C RID: 11788
		private static readonly IntPtr NativeMethodInfoPtr_Write_Internal_Void___BinaryWriter_0;

		// Token: 0x04002E0D RID: 11789
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Internal_Void_0;

		// Token: 0x04002E0E RID: 11790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

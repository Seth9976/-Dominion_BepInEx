using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035A RID: 858
	public sealed class BinaryMethodReturn : Object
	{
		// Token: 0x060036B9 RID: 14009 RVA: 0x00109424 File Offset: 0x00107624
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryMethodReturn()
		{
			Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryMethodReturn");
			BinaryMethodReturn.NativeFieldInfoPtr_returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "returnValue");
			BinaryMethodReturn.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "args");
			BinaryMethodReturn.NativeFieldInfoPtr_callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "callContext");
			BinaryMethodReturn.NativeFieldInfoPtr_argTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "argTypes");
			BinaryMethodReturn.NativeFieldInfoPtr_bArgsPrimitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "bArgsPrimitive");
			BinaryMethodReturn.NativeFieldInfoPtr_messageEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "messageEnum");
			BinaryMethodReturn.NativeFieldInfoPtr_returnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "returnType");
			BinaryMethodReturn.NativeFieldInfoPtr_instanceOfVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "instanceOfVoid");
			BinaryMethodReturn.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, 100671699);
			BinaryMethodReturn.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, 100671700);
			BinaryMethodReturn.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, 100671701);
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x00109528 File Offset: 0x00107728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344999, RefRangeEnd = 345000, XrefRangeStart = 344998, XrefRangeEnd = 344999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryMethodReturn()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodReturn.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x00109564 File Offset: 0x00107764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345012, RefRangeEnd = 345013, XrefRangeStart = 345000, XrefRangeEnd = 345012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodReturn.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x001095A8 File Offset: 0x001077A8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodReturn.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00013B91 File Offset: 0x00011D91
		public BinaryMethodReturn(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060036BE RID: 14014 RVA: 0x001095DC File Offset: 0x001077DC
		// (set) Token: 0x060036BF RID: 14015 RVA: 0x00013B9A File Offset: 0x00011D9A
		public unsafe Object returnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_returnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_returnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060036C0 RID: 14016 RVA: 0x0010960C File Offset: 0x0010780C
		// (set) Token: 0x060036C1 RID: 14017 RVA: 0x00013BB9 File Offset: 0x00011DB9
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x0010963C File Offset: 0x0010783C
		// (set) Token: 0x060036C3 RID: 14019 RVA: 0x00013BD8 File Offset: 0x00011DD8
		public unsafe Object callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x0010966C File Offset: 0x0010786C
		// (set) Token: 0x060036C5 RID: 14021 RVA: 0x00013BF7 File Offset: 0x00011DF7
		public unsafe Il2CppReferenceArray<Type> argTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_argTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_argTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060036C6 RID: 14022 RVA: 0x0010969C File Offset: 0x0010789C
		// (set) Token: 0x060036C7 RID: 14023 RVA: 0x00013C16 File Offset: 0x00011E16
		public unsafe bool bArgsPrimitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_bArgsPrimitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_bArgsPrimitive)) = value;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x001096C4 File Offset: 0x001078C4
		// (set) Token: 0x060036C9 RID: 14025 RVA: 0x00013C31 File Offset: 0x00011E31
		public unsafe MessageEnum messageEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_messageEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_messageEnum)) = value;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x001096EC File Offset: 0x001078EC
		// (set) Token: 0x060036CB RID: 14027 RVA: 0x00013C4C File Offset: 0x00011E4C
		public unsafe Type returnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_returnType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_returnType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060036CC RID: 14028 RVA: 0x0010971C File Offset: 0x0010791C
		// (set) Token: 0x060036CD RID: 14029 RVA: 0x00013C6B File Offset: 0x00011E6B
		public unsafe static Object instanceOfVoid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinaryMethodReturn.NativeFieldInfoPtr_instanceOfVoid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryMethodReturn.NativeFieldInfoPtr_instanceOfVoid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E0F RID: 11791
		private static readonly IntPtr NativeFieldInfoPtr_returnValue;

		// Token: 0x04002E10 RID: 11792
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04002E11 RID: 11793
		private static readonly IntPtr NativeFieldInfoPtr_callContext;

		// Token: 0x04002E12 RID: 11794
		private static readonly IntPtr NativeFieldInfoPtr_argTypes;

		// Token: 0x04002E13 RID: 11795
		private static readonly IntPtr NativeFieldInfoPtr_bArgsPrimitive;

		// Token: 0x04002E14 RID: 11796
		private static readonly IntPtr NativeFieldInfoPtr_messageEnum;

		// Token: 0x04002E15 RID: 11797
		private static readonly IntPtr NativeFieldInfoPtr_returnType;

		// Token: 0x04002E16 RID: 11798
		private static readonly IntPtr NativeFieldInfoPtr_instanceOfVoid;

		// Token: 0x04002E17 RID: 11799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E18 RID: 11800
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002E19 RID: 11801
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}

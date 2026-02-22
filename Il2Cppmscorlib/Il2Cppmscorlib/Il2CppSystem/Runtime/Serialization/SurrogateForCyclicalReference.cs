using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032A RID: 810
	public sealed class SurrogateForCyclicalReference : Object
	{
		// Token: 0x06003472 RID: 13426 RVA: 0x00100BFC File Offset: 0x000FEDFC
		// Note: this type is marked as 'beforefieldinit'.
		static SurrogateForCyclicalReference()
		{
			Il2CppClassPointerStore<SurrogateForCyclicalReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SurrogateForCyclicalReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurrogateForCyclicalReference>.NativeClassPtr);
			SurrogateForCyclicalReference.NativeFieldInfoPtr_innerSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurrogateForCyclicalReference>.NativeClassPtr, "innerSurrogate");
			SurrogateForCyclicalReference.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurrogateForCyclicalReference>.NativeClassPtr, 100671434);
			SurrogateForCyclicalReference.NativeMethodInfoPtr_SetObjectData_Public_Virtual_Final_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurrogateForCyclicalReference>.NativeClassPtr, 100671435);
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x00100C68 File Offset: 0x000FEE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342804, XrefRangeEnd = 342807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(Object obj, SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurrogateForCyclicalReference.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_Object_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x00100CD4 File Offset: 0x000FEED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342807, XrefRangeEnd = 342810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object SetObjectData(Object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurrogateForCyclicalReference.NativeMethodInfoPtr_SetObjectData_Public_Virtual_Final_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x00012ADC File Offset: 0x00010CDC
		public SurrogateForCyclicalReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x00100D60 File Offset: 0x000FEF60
		// (set) Token: 0x06003477 RID: 13431 RVA: 0x00012AE5 File Offset: 0x00010CE5
		public unsafe ISerializationSurrogate innerSurrogate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurrogateForCyclicalReference.NativeFieldInfoPtr_innerSurrogate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurrogateForCyclicalReference.NativeFieldInfoPtr_innerSurrogate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C82 RID: 11394
		private static readonly IntPtr NativeFieldInfoPtr_innerSurrogate;

		// Token: 0x04002C83 RID: 11395
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04002C84 RID: 11396
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectData_Public_Virtual_Final_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0;
	}
}

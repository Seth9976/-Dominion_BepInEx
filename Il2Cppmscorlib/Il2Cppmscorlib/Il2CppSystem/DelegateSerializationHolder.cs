using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000112 RID: 274
	[Serializable]
	public class DelegateSerializationHolder : Object
	{
		// Token: 0x06001457 RID: 5207 RVA: 0x0007F120 File Offset: 0x0007D320
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateSerializationHolder()
		{
			Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DelegateSerializationHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr);
			DelegateSerializationHolder.NativeFieldInfoPtr__delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, "_delegate");
			DelegateSerializationHolder.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, 100666774);
			DelegateSerializationHolder.NativeMethodInfoPtr_GetDelegateData_Public_Static_Void_Delegate_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, 100666775);
			DelegateSerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, 100666776);
			DelegateSerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, 100666777);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0007F1B4 File Offset: 0x0007D3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305778, XrefRangeEnd = 305794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegateSerializationHolder(SerializationInfo info, StreamingContext ctx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0007F218 File Offset: 0x0007D418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305794, XrefRangeEnd = 305828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.NativeMethodInfoPtr_GetDelegateData_Public_Static_Void_Delegate_SerializationInfo_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0007F278 File Offset: 0x0007D478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305828, XrefRangeEnd = 305833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0007F2D4 File Offset: 0x0007D4D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x000071D5 File Offset: 0x000053D5
		public DelegateSerializationHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0007F32C File Offset: 0x0007D52C
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x000071DE File Offset: 0x000053DE
		public unsafe Delegate _delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.NativeFieldInfoPtr__delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.NativeFieldInfoPtr__delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeFieldInfoPtr__delegate;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegateData_Public_Static_Void_Delegate_SerializationInfo_StreamingContext_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0;

		// Token: 0x020005AA RID: 1450
		[Serializable]
		public class DelegateEntry : Object
		{
			// Token: 0x06004FB1 RID: 20401 RVA: 0x00166070 File Offset: 0x00164270
			// Note: this type is marked as 'beforefieldinit'.
			static DelegateEntry()
			{
				Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, "DelegateEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr);
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "type");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "assembly");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "target");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "targetTypeAssembly");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "targetTypeName");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "methodName");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_delegateEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "delegateEntry");
				DelegateSerializationHolder.DelegateEntry.NativeMethodInfoPtr__ctor_Public_Void_Delegate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, 100666778);
				DelegateSerializationHolder.DelegateEntry.NativeMethodInfoPtr_DeserializeDelegate_Public_Delegate_SerializationInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, 100666779);
			}

			// Token: 0x06004FB2 RID: 20402 RVA: 0x00166150 File Offset: 0x00164350
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 305749, RefRangeEnd = 305751, XrefRangeStart = 305743, XrefRangeEnd = 305749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DelegateEntry(Delegate del, string targetLabel)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(del);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetLabel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.DelegateEntry.NativeMethodInfoPtr__ctor_Public_Void_Delegate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FB3 RID: 20403 RVA: 0x001661B0 File Offset: 0x001643B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305751, XrefRangeEnd = 305778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Delegate DeserializeDelegate(SerializationInfo info, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.DelegateEntry.NativeMethodInfoPtr_DeserializeDelegate_Public_Delegate_SerializationInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}

			// Token: 0x06004FB4 RID: 20404 RVA: 0x0001E3D7 File Offset: 0x0001C5D7
			public DelegateEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001446 RID: 5190
			// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x00166210 File Offset: 0x00164410
			// (set) Token: 0x06004FB6 RID: 20406 RVA: 0x0001E3E0 File Offset: 0x0001C5E0
			public unsafe string type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_type);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001447 RID: 5191
			// (get) Token: 0x06004FB7 RID: 20407 RVA: 0x00166238 File Offset: 0x00164438
			// (set) Token: 0x06004FB8 RID: 20408 RVA: 0x0001E3FF File Offset: 0x0001C5FF
			public unsafe string assembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_assembly);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_assembly), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001448 RID: 5192
			// (get) Token: 0x06004FB9 RID: 20409 RVA: 0x00166260 File Offset: 0x00164460
			// (set) Token: 0x06004FBA RID: 20410 RVA: 0x0001E41E File Offset: 0x0001C61E
			public unsafe Object target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001449 RID: 5193
			// (get) Token: 0x06004FBB RID: 20411 RVA: 0x00166290 File Offset: 0x00164490
			// (set) Token: 0x06004FBC RID: 20412 RVA: 0x0001E43D File Offset: 0x0001C63D
			public unsafe string targetTypeAssembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeAssembly);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeAssembly), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700144A RID: 5194
			// (get) Token: 0x06004FBD RID: 20413 RVA: 0x001662B8 File Offset: 0x001644B8
			// (set) Token: 0x06004FBE RID: 20414 RVA: 0x0001E45C File Offset: 0x0001C65C
			public unsafe string targetTypeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700144B RID: 5195
			// (get) Token: 0x06004FBF RID: 20415 RVA: 0x001662E0 File Offset: 0x001644E0
			// (set) Token: 0x06004FC0 RID: 20416 RVA: 0x0001E47B File Offset: 0x0001C67B
			public unsafe string methodName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_methodName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_methodName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700144C RID: 5196
			// (get) Token: 0x06004FC1 RID: 20417 RVA: 0x00166308 File Offset: 0x00164508
			// (set) Token: 0x06004FC2 RID: 20418 RVA: 0x0001E49A File Offset: 0x0001C69A
			public unsafe DelegateSerializationHolder.DelegateEntry delegateEntry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_delegateEntry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateSerializationHolder.DelegateEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_delegateEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040040E5 RID: 16613
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040040E6 RID: 16614
			private static readonly IntPtr NativeFieldInfoPtr_assembly;

			// Token: 0x040040E7 RID: 16615
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040040E8 RID: 16616
			private static readonly IntPtr NativeFieldInfoPtr_targetTypeAssembly;

			// Token: 0x040040E9 RID: 16617
			private static readonly IntPtr NativeFieldInfoPtr_targetTypeName;

			// Token: 0x040040EA RID: 16618
			private static readonly IntPtr NativeFieldInfoPtr_methodName;

			// Token: 0x040040EB RID: 16619
			private static readonly IntPtr NativeFieldInfoPtr_delegateEntry;

			// Token: 0x040040EC RID: 16620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Delegate_String_0;

			// Token: 0x040040ED RID: 16621
			private static readonly IntPtr NativeMethodInfoPtr_DeserializeDelegate_Public_Delegate_SerializationInfo_Int32_0;
		}
	}
}

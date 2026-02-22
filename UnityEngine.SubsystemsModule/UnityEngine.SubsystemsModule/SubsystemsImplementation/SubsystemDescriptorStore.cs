using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.SubsystemsImplementation
{
	// Token: 0x0200000C RID: 12
	public static class SubsystemDescriptorStore : Object
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000031F8 File Offset: 0x000013F8
		// Note: this type is marked as 'beforefieldinit'.
		static SubsystemDescriptorStore()
		{
			Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine.SubsystemsImplementation", "SubsystemDescriptorStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr);
			SubsystemDescriptorStore.NativeFieldInfoPtr_s_IntegratedDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, "s_IntegratedDescriptors");
			SubsystemDescriptorStore.NativeFieldInfoPtr_s_StandaloneDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, "s_StandaloneDescriptors");
			SubsystemDescriptorStore.NativeFieldInfoPtr_s_DeprecatedDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, "s_DeprecatedDescriptors");
			SubsystemDescriptorStore.NativeMethodInfoPtr_InitializeManagedDescriptor_Internal_Static_Void_IntPtr_IntegratedSubsystemDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663316);
			SubsystemDescriptorStore.NativeMethodInfoPtr_ClearManagedDescriptors_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663317);
			SubsystemDescriptorStore.NativeMethodInfoPtr_ReportSingleSubsystemAnalytics_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663318);
			SubsystemDescriptorStore.NativeMethodInfoPtr_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663319);
			SubsystemDescriptorStore.NativeMethodInfoPtr_RegisterDeprecatedDescriptor_Internal_Static_Void_SubsystemDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663320);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000032C8 File Offset: 0x000014C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131594, XrefRangeEnd = 131602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorStore.NativeMethodInfoPtr_InitializeManagedDescriptor_Internal_Static_Void_IntPtr_IntegratedSubsystemDescriptor_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000330C File Offset: 0x0000150C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131602, XrefRangeEnd = 131627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearManagedDescriptors()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorStore.NativeMethodInfoPtr_ClearManagedDescriptors_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003334 File Offset: 0x00001534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131627, XrefRangeEnd = 131651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportSingleSubsystemAnalytics(string id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorStore.NativeMethodInfoPtr_ReportSingleSubsystemAnalytics_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000336C File Offset: 0x0000156C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131672, RefRangeEnd = 131674, XrefRangeStart = 131651, XrefRangeEnd = 131672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList) where TDescriptor : TBaseTypeInList
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TDescriptor).IsValueType)
				{
					TDescriptor tdescriptor = descriptor;
					intPtr = ((tdescriptor is string) ? IL2CPP.ManagedStringToIl2Cpp(tdescriptor as string) : IL2CPP.Il2CppObjectBaseToPtr(tdescriptor as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref descriptor;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storeInList);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorStore.MethodInfoStoreGeneric_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0<TDescriptor, TBaseTypeInList>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000033EC File Offset: 0x000015EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131674, XrefRangeEnd = 131681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorStore.NativeMethodInfoPtr_RegisterDeprecatedDescriptor_Internal_Static_Void_SubsystemDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002393 File Offset: 0x00000593
		public SubsystemDescriptorStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00003424 File Offset: 0x00001624
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0000239C File Offset: 0x0000059C
		public unsafe static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemDescriptorStore.NativeFieldInfoPtr_s_IntegratedDescriptors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IntegratedSubsystemDescriptor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemDescriptorStore.NativeFieldInfoPtr_s_IntegratedDescriptors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000344C File Offset: 0x0000164C
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000023AE File Offset: 0x000005AE
		public unsafe static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemDescriptorStore.NativeFieldInfoPtr_s_StandaloneDescriptors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SubsystemDescriptorWithProvider>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemDescriptorStore.NativeFieldInfoPtr_s_StandaloneDescriptors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00003474 File Offset: 0x00001674
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000023C0 File Offset: 0x000005C0
		public unsafe static List<SubsystemDescriptor> s_DeprecatedDescriptors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemDescriptorStore.NativeFieldInfoPtr_s_DeprecatedDescriptors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SubsystemDescriptor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemDescriptorStore.NativeFieldInfoPtr_s_DeprecatedDescriptors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000023D2 File Offset: 0x000005D2
		public static void RegisterDescriptor(SubsystemDescriptorWithProvider descriptor)
		{
			descriptor.ThrowIfInvalid();
			SubsystemDescriptorStore.RegisterDescriptor<SubsystemDescriptorWithProvider, SubsystemDescriptorWithProvider>(descriptor, SubsystemDescriptorStore.s_StandaloneDescriptors);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000349C File Offset: 0x0000169C
		public static void GetAllSubsystemDescriptors(List<ISubsystemDescriptor> descriptors)
		{
			descriptors.Clear();
			int num = SubsystemDescriptorStore.s_IntegratedDescriptors.Count + SubsystemDescriptorStore.s_StandaloneDescriptors.Count + SubsystemDescriptorStore.s_DeprecatedDescriptors.Count;
			bool flag = descriptors.Capacity < num;
			if (flag)
			{
				descriptors.Capacity = num;
			}
			SubsystemDescriptorStore.AddDescriptorSubset<IntegratedSubsystemDescriptor>(SubsystemDescriptorStore.s_IntegratedDescriptors, descriptors);
			SubsystemDescriptorStore.AddDescriptorSubset<SubsystemDescriptorWithProvider>(SubsystemDescriptorStore.s_StandaloneDescriptors, descriptors);
			SubsystemDescriptorStore.AddDescriptorSubset<SubsystemDescriptor>(SubsystemDescriptorStore.s_DeprecatedDescriptors, descriptors);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000350C File Offset: 0x0000170C
		public static void AddDescriptorSubset<TBaseTypeInList>(List<TBaseTypeInList> copyFrom, List<ISubsystemDescriptor> copyTo)
		{
			List<TBaseTypeInList>.Enumerator enumerator = copyFrom.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBaseTypeInList tbaseTypeInList = enumerator.Current;
					copyTo.Add(tbaseTypeInList);
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000023E8 File Offset: 0x000005E8
		public static void GetSubsystemDescriptors<T>(List<T> descriptors)
		{
			descriptors.Clear();
			SubsystemDescriptorStore.AddDescriptorSubset<IntegratedSubsystemDescriptor, T>(SubsystemDescriptorStore.s_IntegratedDescriptors, descriptors);
			SubsystemDescriptorStore.AddDescriptorSubset<SubsystemDescriptorWithProvider, T>(SubsystemDescriptorStore.s_StandaloneDescriptors, descriptors);
			SubsystemDescriptorStore.AddDescriptorSubset<SubsystemDescriptor, T>(SubsystemDescriptorStore.s_DeprecatedDescriptors, descriptors);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003564 File Offset: 0x00001764
		public static void AddDescriptorSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo)
		{
			List<TBaseTypeInList>.Enumerator enumerator = copyFrom.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBaseTypeInList tbaseTypeInList = enumerator.Current;
					TQueryType tqueryType;
					bool flag;
					if (tbaseTypeInList.TryCast<TQueryType>() != null)
					{
						tqueryType = tbaseTypeInList.TryCast<TQueryType>().Cast<TQueryType>();
						flag = true;
					}
					else
					{
						flag = false;
					}
					bool flag2 = flag;
					if (flag2)
					{
						copyTo.Add(tqueryType);
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_s_IntegratedDescriptors;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_s_StandaloneDescriptors;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_s_DeprecatedDescriptors;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_InitializeManagedDescriptor_Internal_Static_Void_IntPtr_IntegratedSubsystemDescriptor_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_ClearManagedDescriptors_Internal_Static_Void_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_ReportSingleSubsystemAnalytics_Private_Static_Void_String_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDeprecatedDescriptor_Internal_Static_Void_SubsystemDescriptor_0;

		// Token: 0x0200001C RID: 28
		private sealed class MethodInfoStoreGeneric_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0<TDescriptor, TBaseTypeInList>
		{
			// Token: 0x04000036 RID: 54
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SubsystemDescriptorStore.NativeMethodInfoPtr_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0, Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDescriptor>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBaseTypeInList>.NativeClassPtr))
			}))));
		}
	}
}

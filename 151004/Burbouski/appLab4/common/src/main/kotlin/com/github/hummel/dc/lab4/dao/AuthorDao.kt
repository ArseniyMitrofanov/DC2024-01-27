package com.github.hummel.dc.lab4.dao

import com.github.hummel.dc.lab4.bean.Author

interface AuthorDao {
	suspend fun create(item: Author): Long

	suspend fun deleteById(id: Long): Int

	suspend fun getAll(): List<Author?>

	suspend fun getById(id: Long): Author

	suspend fun update(item: Author): Int
}